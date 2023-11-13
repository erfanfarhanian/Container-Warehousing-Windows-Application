namespace Store_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnShowFrmTariff = new DevExpress.XtraBars.BarButtonItem();
            this.btnShowFrmEnterAndExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnNameOfOwnerReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnContainerNumberReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory2 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory3 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnShowFrmTariff,
            this.btnShowFrmEnterAndExit,
            this.btnNameOfOwnerReport,
            this.btnContainerNumberReport,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1,
            this.ribbonPageCategory2,
            this.ribbonPageCategory3});
            this.ribbonControl1.Size = new System.Drawing.Size(1135, 209);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.btnShowFrmTariff);
            this.applicationMenu1.ItemLinks.Add(this.btnShowFrmEnterAndExit);
            this.applicationMenu1.ItemLinks.Add(this.btnNameOfOwnerReport);
            this.applicationMenu1.ItemLinks.Add(this.btnContainerNumberReport);
            this.applicationMenu1.ItemLinks.Add(this.barButtonItem1);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // btnShowFrmTariff
            // 
            this.btnShowFrmTariff.Caption = "نمایش فرم تعرفه ها";
            this.btnShowFrmTariff.Id = 1;
            this.btnShowFrmTariff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowFrmTariff.ImageOptions.Image")));
            this.btnShowFrmTariff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShowFrmTariff.ImageOptions.LargeImage")));
            this.btnShowFrmTariff.Name = "btnShowFrmTariff";
            this.btnShowFrmTariff.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnShowFrmTariff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowFrmTariff_ItemClick);
            // 
            // btnShowFrmEnterAndExit
            // 
            this.btnShowFrmEnterAndExit.Caption = "نمایش فرم اطلاعات کانتینرها";
            this.btnShowFrmEnterAndExit.Id = 2;
            this.btnShowFrmEnterAndExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowFrmEnterAndExit.ImageOptions.Image")));
            this.btnShowFrmEnterAndExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShowFrmEnterAndExit.ImageOptions.LargeImage")));
            this.btnShowFrmEnterAndExit.Name = "btnShowFrmEnterAndExit";
            this.btnShowFrmEnterAndExit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnShowFrmEnterAndExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowFrmEnterAndExit_ItemClick);
            // 
            // btnNameOfOwnerReport
            // 
            this.btnNameOfOwnerReport.Caption = "هزینه انبارداری به تفکیک صاحب کالا";
            this.btnNameOfOwnerReport.Id = 3;
            this.btnNameOfOwnerReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNameOfOwnerReport.ImageOptions.Image")));
            this.btnNameOfOwnerReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNameOfOwnerReport.ImageOptions.LargeImage")));
            this.btnNameOfOwnerReport.Name = "btnNameOfOwnerReport";
            this.btnNameOfOwnerReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNameOfOwnerReport_ItemClick);
            // 
            // btnContainerNumberReport
            // 
            this.btnContainerNumberReport.Caption = "هزینه انبارداری به تفکیک کانتینر";
            this.btnContainerNumberReport.Id = 4;
            this.btnContainerNumberReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnContainerNumberReport.ImageOptions.Image")));
            this.btnContainerNumberReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnContainerNumberReport.ImageOptions.LargeImage")));
            this.btnContainerNumberReport.Name = "btnContainerNumberReport";
            this.btnContainerNumberReport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnContainerNumberReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContainerNumberReport_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "خروج";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonPageCategory1.Text = "انبارداری کانتینرها";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "تعرفه ها و ورود و خروج کانتینرها ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowFrmTariff);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowFrmEnterAndExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "تعرفه ها و اطلاعات انبارداری";
            // 
            // ribbonPageCategory2
            // 
            this.ribbonPageCategory2.Name = "ribbonPageCategory2";
            this.ribbonPageCategory2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonPageCategory2.Text = "گزارشات";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "گزارشات کانتینرها";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNameOfOwnerReport);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "هزینه انبارداری به تفکیک صاحب کالا";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnContainerNumberReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "هزینه انبارداری به تفکیک کانتینرها";
            // 
            // ribbonPageCategory3
            // 
            this.ribbonPageCategory3.Name = "ribbonPageCategory3";
            this.ribbonPageCategory3.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3});
            this.ribbonPageCategory3.Text = "خروج";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "خروج از برنامه";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "خروج";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1135, 628);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMain.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نرم افزار انبارداری کانتینرها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnShowFrmTariff;
        private DevExpress.XtraBars.BarButtonItem btnShowFrmEnterAndExit;
        private DevExpress.XtraBars.BarButtonItem btnNameOfOwnerReport;
        private DevExpress.XtraBars.BarButtonItem btnContainerNumberReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}

