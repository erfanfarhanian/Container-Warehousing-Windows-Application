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
    public partial class frmInsertAndUpdateTariff : DevExpress.XtraEditors.XtraForm
    {
        public int tariffID = 0;

        public frmInsertAndUpdateTariff()
        {
            InitializeComponent();
        }
        public frmInsertAndUpdateTariff(int TariffID) : this()
        {
            tariffID = TariffID;
        }

        #region [Events]

        private void frmInsertAndUpdateTariff_Load(object sender, EventArgs e)
        {
            DisplayCode();
            DisplayTillDay();
            if (tariffID != 0)
            {
                LoadCurrentTariff(tariffID);
            }
        }

        private void btnInsertOrUpdate_Click(object sender, EventArgs e)
        {
            if (txtTariffCode.Text == "" || txtFromDay.Text == "" || txtTillDay.Text == "" || txtDailyCost.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به طور کامل وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.CompareOrdinal(txtTillDay.Text, txtFromDay.Text) < 0)
            {
                MessageBox.Show("روز شروع باید کمتر از روز پایان باشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (Convert.ToInt32(txtTariffCode.Text) > 4)
            //{
            //    MessageBox.Show("لطفا شناسه را به درستی وارد کنید" + "\n" +"فقط تا 4 عدد تعرفه می توان وارد کرد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            else if (Convert.ToInt32(txtTillDay.Text) <= 0 || Convert.ToInt32(txtDailyCost.Text) < 0)
            {
                MessageBox.Show("لطفا اعداد منفی وارد نفرمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Convert.ToInt32(txtFromDay.Text) == Convert.ToInt32(txtTillDay.Text))
            {
                MessageBox.Show("روز شروع و روز پایان نمی توانند با یکدیگر برابر باشند", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tariffID == 0)
            {
                InsertTariff();
            }
            else
            {
                UpdateCurrentTariff();

            }
            this.DialogResult = DialogResult.OK;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtTariffCode_Validating(object sender, CancelEventArgs e)
        {
            if (!ISTariffCodeValid())
            {
                TariffErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                TariffErrorProvider.SetError((Control)sender, "لطفا کد تعرفه را وارد کنید");
            }
            else
            {
                TariffErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtFromDay_Validating(object sender, CancelEventArgs e)
        {
            if (!ISFromDayValid())
            {
                TariffErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                TariffErrorProvider.SetError((Control)sender, "لطفا روز شروع را وارد کنید");
            }
            else
            {
                TariffErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtTillDay_Validating(object sender, CancelEventArgs e)
        {
            if (!ISTillDayValid())
            {
                TariffErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                TariffErrorProvider.SetError((Control)sender, "لطفا روز پایان را وارد کنید");
            }
            else
            {
                TariffErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtDailyCost_Validating(object sender, CancelEventArgs e)
        {
            if (!ISDailyCostValid())
            {
                TariffErrorProvider.SetIconAlignment((Control)sender, ErrorIconAlignment.MiddleRight);
                TariffErrorProvider.SetError((Control)sender, "لطفا مبلغ روزانه را وارد کنید");
            }
            else
            {
                TariffErrorProvider.SetError((Control)sender, "");
            }
        }

        private void txtTariffCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFromDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTillDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("لطفا فقط عدد وارد نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtDailyCost_KeyPress(object sender, KeyPressEventArgs e)
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
        /// نمایش خودکار روز شروع
        /// </summary>
        private void DisplayTillDay()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Tariff_SelectTillDay]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dsTariff = new DataSet();
                da.Fill(dsTariff);
                if (dsTariff.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ تعرفه ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtFromDay.Text = dsTariff.Tables[0].Rows[0]["LastFromDay"].ToString();
                txtFromDay.ReadOnly = true;
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
        /// نمایش خودکار شناسه تعرفه
        /// </summary>
        private void DisplayCode()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Tariff_SelectCode]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dsTariff = new DataSet();
                da.Fill(dsTariff);
                if (dsTariff.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ تعرفه ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtTariffCode.Text = dsTariff.Tables[0].Rows[0]["LastCode"].ToString();
                txtTariffCode.Enabled = false;
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
        /// نمایش اطلاعات انتخاب شده
        /// </summary>
        /// <param name="tariffID">شناسه تعرفه</param>
        private void LoadCurrentTariff(int tariffID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Tariff_SelectRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Code", tariffID);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dsTariff = new DataSet();
                da.Fill(dsTariff);
                if (dsTariff.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("هیچ تعرفه ای وجود ندارد ", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtTariffCode.Text = dsTariff.Tables[0].Rows[0]["Code"].ToString();
                txtTariffCode.Enabled = false;
                txtFromDay.Text = dsTariff.Tables[0].Rows[0]["FromDay"].ToString();
                txtTillDay.Text = dsTariff.Tables[0].Rows[0]["TillDay"].ToString();
                txtDailyCost.Text = dsTariff.Tables[0].Rows[0]["DailyCost"].ToString();
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
        /// افزودن تعرفه
        /// </summary>
        public void InsertTariff()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Tariff_InsertRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Code", txtTariffCode.Text);
                cmd.Parameters.AddWithValue("FromDay", txtFromDay.Text);
                cmd.Parameters.AddWithValue("TillDay", txtTillDay.Text);
                cmd.Parameters.AddWithValue("DailyCost", txtDailyCost.Text);
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
        /// ویرایش تعرفه مورد نظر
        /// </summary>
        private void UpdateCurrentTariff()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Tariff_UpdateRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Code", tariffID);
                cmd.Parameters.AddWithValue("FromDay", txtFromDay.Text);
                cmd.Parameters.AddWithValue("TillDay", txtTillDay.Text);
                cmd.Parameters.AddWithValue("DailyCost", txtDailyCost.Text);

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

        //ارور پر کردن تکست باکس ها
        private bool ISFromDayValid()
        {
            return txtFromDay.Text.Length > 0;
        }
        private bool ISTillDayValid()
        {
            return txtTillDay.Text.Length > 0;
        }
        private bool ISDailyCostValid()
        {
            return txtDailyCost.Text.Length > 0;
        }
        private bool ISTariffCodeValid()
        {
            return txtTariffCode.Text.Length > 0;
        }

        #endregion
    }
}