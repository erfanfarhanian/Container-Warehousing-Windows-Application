using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace Store_Project
{
    public partial class frmTariff : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int tariffID = 0;
        public int getFromDay = 0;

        public frmTariff()
        {
            InitializeComponent();
        }

        #region [Events]

        private void btnShowTariff_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadGrdTariff();
        }
        
        private void btnInsertTariff_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (grdTariff.RowCount > 3)
            {
                MessageBox.Show("متاسفانه مجاز به افزودن تعرفه نمی باشید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmInsertAndUpdateTariff frmInsertAndUpdateTariff = new frmInsertAndUpdateTariff();
            DialogResult result = frmInsertAndUpdateTariff.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadGrdTariff();
            }
        }

        private void btnUpdateTariff_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tariffID == 0)
            {
                MessageBox.Show("هیچ داده ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmInsertAndUpdateTariff frmInsertAndUpdateTariff = new frmInsertAndUpdateTariff(tariffID);
                frmInsertAndUpdateTariff.txtTillDay.ReadOnly = true;
                DialogResult result = frmInsertAndUpdateTariff.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadGrdTariff();
                }
            }
        }
        
        private void grdTariff_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tariffID = Convert.ToInt32(grdTariff.GetDataRow(e.RowHandle)["Code"]);
        }

        private void btnDelTariff_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tariffID == 0)
            {
                MessageBox.Show("هیچ داده ای انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult res = MessageBox.Show("با حذف این تعرفه تمام اطلاعات مربوط به آن حذف می شود" + "\n" + "آیا از حذف این داده اطمینان دارید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (tariffID < grdTariff.RowCount)
                {
                    MessageBox.Show("شما مجاز به حذف تعرفه نمی باشید" + "\n" + "تعرفه ها تنها می توانند به ترتیب از آخر حذف شوند", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DeleteData(tariffID);
                LoadGrdTariff();
            }
            else
                MessageBox.Show("عملیات حذف لغو شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frmTariff_Load(object sender, EventArgs e)
        {
            LoadGrdTariff();
        }

        private void btnReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// نمایش تعرفه ها در گرید تعرفه
        /// </summary>
        private void LoadGrdTariff()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_TblTariff_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                grd2.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("وقوع مشکل در هنگام کار با پایگاه داده" + "\n" + ex.Message, "خطای بانک اطلاعاتی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "/n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// حذف تعرفه از دیتابیس
        /// </summary>
        /// <param name="selectedID">تعرفه انتخاب شده</param>
        private void DeleteData(int selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Tariff_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Code", selectedID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show("هیچ داده ای انتخاب نشده است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}