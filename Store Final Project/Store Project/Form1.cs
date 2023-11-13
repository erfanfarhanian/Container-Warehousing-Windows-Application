using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Stimulsoft.Report;

namespace Store_Project
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowFrmTariff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTariff frmTariff = new frmTariff();
            frmTariff.ShowDialog();
        }

        private void btnShowFrmEnterAndExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOwner frmOwner = new frmOwner();
            frmOwner.ShowDialog();
        }

        #region [Reports]

        private void btnNameOfOwnerReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"ReportFiles\Report_usp_OwnerAndTariff_SelectAllByNameOfOwnerCost.mrt");
            report.Compile();
            report.Show(this);
        }

        private void btnContainerNumberReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StiReport report = new StiReport();
            report.Load(@"ReportFiles\Report_usp_OwnerAndTariff_SelectAllByContainerNumberCost.mrt");
            report.Compile();
            report.Show(this);
        }

        #endregion

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("آیا قصد دارید از برنامه خارج شوید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("به امید دیدار مجدد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                MessageBox.Show("عملیات خروج لغو شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
