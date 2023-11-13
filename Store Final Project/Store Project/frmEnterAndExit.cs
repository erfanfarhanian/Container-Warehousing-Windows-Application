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
using Stimulsoft.Report;

namespace Store_Project
{
    public partial class frmOwner : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        long ownerID = 0;
        public frmOwner()
        {
            InitializeComponent();
        }

        #region [Events]        
        private void btnShowOwner_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadGrdOwner();
        }
        

        private void btnInsertOwner_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnInsertOwner_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            frmInsertAndUpdateOwner frmInsertAndUpdateOwner = new frmInsertAndUpdateOwner();
            DialogResult result = frmInsertAndUpdateOwner.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadGrdOwner();
            }
        }

        private void btnUpdateOwner_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ownerID == 0)
            {
                MessageBox.Show("هیچ داده ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmInsertAndUpdateOwner frmInsertAndUpdateOwner = new frmInsertAndUpdateOwner(ownerID);
                DialogResult result = frmInsertAndUpdateOwner.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadGrdOwner();
                }
            }
        }

        private void grdOwner_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void grdOwner_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ownerID = Convert.ToInt64(grdOwner.GetDataRow(e.RowHandle)["ID"]);
        }

        private void btnDelOwner_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ownerID == 0)
            {
                MessageBox.Show("هیچ داده ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult res = MessageBox.Show("با حذف این داده تمام اطلاعات مربوط به آن حذف می شود" + "\n" + "آیا از حذف این داده اطمینان دارید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                DeleteData(ownerID);
                LoadGrdOwner();
            }
            else
                MessageBox.Show("عملیات حذف لغو شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void btnReportByName_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (ownerID == 0)
                {
                    MessageBox.Show("هیچ داده ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                StiReport report = new StiReport();
                report.Load(@"ReportFiles\Report_usp_OwnerAndTariff_TotalPriceByID.mrt");
                report.Dictionary.Variables["ID"].Value = ownerID.ToString();
                report.Compile();
                report.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("وقوع مشکل در سیستم" + "\n" + ex.Message, "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmOwner_Load(object sender, EventArgs e)
        {
            LoadGrdOwner();
        }
        #endregion

        #region [Methods]

        /// <summary>
        /// نمایش اطلاعات کانتینر در گرید
        /// </summary>
        private void LoadGrdOwner()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Owner_SelectAll]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                grd.DataSource = ds.Tables[0];
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
        /// حذف کانتینر از دیتابیس
        /// </summary>
        /// <param name="selectedID">داده انتخاب شده</param>
        private void DeleteData(long selectedID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "data source = . ; initial catalog = DBStore ; integrated security = true";
                string query = "[dbo].[usp_Owner_DeleteRow]";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID", selectedID);
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