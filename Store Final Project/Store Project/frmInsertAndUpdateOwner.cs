using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Store_Project
{
    public partial class frmInsertAndUpdateOwner : DevExpress.XtraEditors.XtraForm
    {
        #region [Properties]
        public long ownerID = 0;
        DateTime selectedEnterDate;
        DateTime selectedExitDate;
        #endregion

        public frmInsertAndUpdateOwner()
        {
            InitializeComponent();
        }
        public frmInsertAndUpdateOwner(long OwnerID) : this()
        {
            ownerID = OwnerID;
        }

        #region [Events]

        private void btnInsertOrEditOwner_Click(object sender, EventArgs e)
        {
            if (txtNameOfOwner.Text == "" || txtTelOfOwner.Text == "" || txtContainerNumber.Text == "" || txtEnterDate.Value == null)
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEnterDate.Value > txtExitDate.Value)
            {
                MessageBox.Show("لطفا تاریخ ورود و خروج را به درستی وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ownerID == 0)
            {
                InsertOwner();
            }
            else
                UpdateCurrentOwner();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmInsertAndUpdateOwner_Load(object sender, EventArgs e)
        {
            if (ownerID != 0)
            {
                LoadCurrentOwner(ownerID);
            }
        }

        private void txtNameOfOwner_Validating(object sender, CancelEventArgs e)
        {
            if (!IsNameOfOwnerValid())
            {
                ContinerErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                ContinerErrorProvider.SetError((Control)sender, "لطفا نام و نام خانوادگی را وارد کنید");
            }
            else
            {
                ContinerErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtTelOfOwner_Validating(object sender, CancelEventArgs e)
        {
            if (!IsTelOfOwnerValid())
            {
                ContinerErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                ContinerErrorProvider.SetError((Control)sender, "لطفا شماره همراه را وارد کنید");
            }
            else
            {
                ContinerErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtContainerNumber_Validated(object sender, EventArgs e)
        {
            if (!IsContainerNumberValid())
            {
                ContinerErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                ContinerErrorProvider.SetError((Control)sender, "لطفا شماره کانتینر را وارد کنید");
            }
            else
            {
                ContinerErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtTelOfOwner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// نمایش اطلاعات انتخاب شده
        /// </summary>
        /// <param name="tariffID">شناسه داده</param>
        private void LoadCurrentOwner(long ownerID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Owner_SelectRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID", ownerID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dsOwner = new DataSet();
                da.Fill(dsOwner);
                if (dsOwner.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ تعرفه ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtNameOfOwner.Text = dsOwner.Tables[0].Rows[0]["NameOfOwner"].ToString();
                txtTelOfOwner.Text = dsOwner.Tables[0].Rows[0]["TelOfOwner"].ToString();
                txtContainerNumber.Text = dsOwner.Tables[0].Rows[0]["ContainerNumber"].ToString();
                DateTime.TryParse(dsOwner.Tables[0].Rows[0]["EnterDate"].ToString().Trim(), out selectedEnterDate);
                DateTime.TryParse(dsOwner.Tables[0].Rows[0]["ExitDate"].ToString(), out selectedExitDate);
                txtEnterDate.Value = selectedEnterDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedEnterDate;
                txtExitDate.Value = selectedExitDate.Equals(new DateTime(1, 1, 1)) ? null : (DateTime?)selectedExitDate;
                rdNotSettled.Checked = dsOwner.Tables[0].Rows[0]["IsSettled"].ToString() == "False" ? true : false;
                rdSettled.Checked = dsOwner.Tables[0].Rows[0]["IsSettled"].ToString() == "True" ? true : false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// افزودن کانتینر جدید
        /// </summary>
        private void InsertOwner()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Owner_InsertRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("NameOfOwner", txtNameOfOwner.Text);
                cmd.Parameters.AddWithValue("TelOfOwner", txtTelOfOwner.Text);
                cmd.Parameters.AddWithValue("ContainerNumber", txtContainerNumber.Text);
                cmd.Parameters.AddWithValue("EnterDate", txtEnterDate.Value); // از نوع DateTime
                cmd.Parameters.AddWithValue("ExitDate", txtExitDate.Value); // از نوع DateTime
                cmd.Parameters.AddWithValue("EnterDateShamsi", txtEnterDate.GetText("yyyy/MM/dd")); // از نوع رشته
                cmd.Parameters.AddWithValue("ExitDateShamsi", txtExitDate.GetText("yyyy/MM/dd")); // از نوع رشته
                cmd.Parameters.AddWithValue("IsSettled", rdNotSettled.Checked ? 0 : 1);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ داده ای اضافه نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// ویرایش کانتینر مورد نظر
        /// </summary>
        private void UpdateCurrentOwner()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Owner_UpdateRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID", ownerID);
                cmd.Parameters.AddWithValue("NameOfOwner", txtNameOfOwner.Text);
                cmd.Parameters.AddWithValue("TelOfOwner", txtTelOfOwner.Text);
                cmd.Parameters.AddWithValue("ContainerNumber", txtContainerNumber.Text);
                cmd.Parameters.AddWithValue("EnterDate", txtEnterDate.Value); // از نوع DateTime
                cmd.Parameters.AddWithValue("ExitDate", txtExitDate.Value); // از نوع DateTime
                cmd.Parameters.AddWithValue("EnterDateShamsi", txtEnterDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("ExitDateShamsi", txtExitDate.GetText("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("IsSettled", rdNotSettled.Checked ? 0 : 1);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ تعرفه ای ویرایش نشد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region [Methods For Textbox Validating Event]

        // ارور پر کردن تکست باکس ها
        private bool IsNameOfOwnerValid()
        {
            return txtNameOfOwner.Text.Length > 0;
        }
        private bool IsContainerNumberValid()
        {
            return txtContainerNumber.Text.Length > 0;
        }
        private bool IsTelOfOwnerValid()
        {
            return txtTelOfOwner.Text.Length > 0;
        }

        #endregion
    }
}