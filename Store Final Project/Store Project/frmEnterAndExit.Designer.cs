namespace Store_Project
{
    partial class frmOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOwner));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnShowOwner = new DevExpress.XtraBars.BarButtonItem();
            this.btnInsertOwner = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturn = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateOwner = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelOwner = new DevExpress.XtraBars.BarButtonItem();
            this.btnReportByName = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory2 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.grpOwnerInfo = new DevExpress.XtraEditors.GroupControl();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grdOwner = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnNameOfOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnTelOfOwner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnContainerNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnEnterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnExitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnIsSettled = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOwnerInfo)).BeginInit();
            this.grpOwnerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnShowOwner,
            this.btnInsertOwner,
            this.btnUpdateOwner,
            this.btnDelOwner,
            this.btnReportByName,
            this.btnReturn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1,
            this.ribbonPageCategory2});
            this.ribbon.Size = new System.Drawing.Size(1080, 209);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.btnShowOwner);
            this.applicationMenu1.ItemLinks.Add(this.btnInsertOwner);
            this.applicationMenu1.ItemLinks.Add(this.btnReturn);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // btnShowOwner
            // 
            this.btnShowOwner.Caption = "نمایش اطلاعات ورود و خروج";
            this.btnShowOwner.Id = 1;
            this.btnShowOwner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowOwner.ImageOptions.Image")));
            this.btnShowOwner.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShowOwner.ImageOptions.LargeImage")));
            this.btnShowOwner.Name = "btnShowOwner";
            this.btnShowOwner.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnShowOwner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowOwner_ItemClick);
            // 
            // btnInsertOwner
            // 
            this.btnInsertOwner.Caption = "افزودن داده";
            this.btnInsertOwner.Id = 2;
            this.btnInsertOwner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertOwner.ImageOptions.Image")));
            this.btnInsertOwner.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInsertOwner.ImageOptions.LargeImage")));
            this.btnInsertOwner.Name = "btnInsertOwner";
            this.btnInsertOwner.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnInsertOwner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsertOwner_ItemClick_1);
            // 
            // btnReturn
            // 
            this.btnReturn.Caption = "بازگشت";
            this.btnReturn.Id = 6;
            this.btnReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.Image")));
            this.btnReturn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.LargeImage")));
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReturn_ItemClick);
            // 
            // btnUpdateOwner
            // 
            this.btnUpdateOwner.Caption = "ویرایش داده";
            this.btnUpdateOwner.Id = 3;
            this.btnUpdateOwner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateOwner.ImageOptions.Image")));
            this.btnUpdateOwner.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateOwner.ImageOptions.LargeImage")));
            this.btnUpdateOwner.Name = "btnUpdateOwner";
            this.btnUpdateOwner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateOwner_ItemClick);
            // 
            // btnDelOwner
            // 
            this.btnDelOwner.Caption = "حذف داده";
            this.btnDelOwner.Id = 4;
            this.btnDelOwner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelOwner.ImageOptions.Image")));
            this.btnDelOwner.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelOwner.ImageOptions.LargeImage")));
            this.btnDelOwner.Name = "btnDelOwner";
            this.btnDelOwner.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelOwner_ItemClick);
            // 
            // btnReportByName
            // 
            this.btnReportByName.Caption = "چاپ صورتحساب";
            this.btnReportByName.Id = 5;
            this.btnReportByName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReportByName.ImageOptions.Image")));
            this.btnReportByName.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReportByName.ImageOptions.LargeImage")));
            this.btnReportByName.Name = "btnReportByName";
            this.btnReportByName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReportByName_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonPageCategory1.Text = "کانتینرها";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "نمایش، افزودن، ویرایش، حذف";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowOwner);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "نمایش اطلاعات";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInsertOwner);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUpdateOwner);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDelOwner);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "افزودن، ویرایش و حذف اطلاعات";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "گزارش";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReportByName);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "صورتحساب";
            // 
            // ribbonPageCategory2
            // 
            this.ribbonPageCategory2.Name = "ribbonPageCategory2";
            this.ribbonPageCategory2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3});
            this.ribbonPageCategory2.Text = "بازگشت";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "بازگشت به فرم اصلی";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnReturn);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "بازگشت";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 548);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1080, 30);
            // 
            // grpOwnerInfo
            // 
            this.grpOwnerInfo.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpOwnerInfo.CaptionImageOptions.Image")));
            this.grpOwnerInfo.Controls.Add(this.grd);
            this.grpOwnerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpOwnerInfo.Location = new System.Drawing.Point(0, 209);
            this.grpOwnerInfo.Name = "grpOwnerInfo";
            this.grpOwnerInfo.Size = new System.Drawing.Size(1080, 339);
            this.grpOwnerInfo.TabIndex = 3;
            this.grpOwnerInfo.Text = "اطلاعات صاحب کالا";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(2, 33);
            this.grd.MainView = this.grdOwner;
            this.grd.MenuManager = this.ribbon;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(1076, 304);
            this.grd.TabIndex = 0;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdOwner});
            // 
            // grdOwner
            // 
            this.grdOwner.Appearance.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.grdOwner.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdOwner.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdOwner.Appearance.OddRow.Options.UseBackColor = true;
            this.grdOwner.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.grdOwner.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.grdOwner.Appearance.Row.Options.UseBackColor = true;
            this.grdOwner.Appearance.Row.Options.UseTextOptions = true;
            this.grdOwner.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdOwner.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnID,
            this.clmnNameOfOwner,
            this.clmnTelOfOwner,
            this.clmnContainerNumber,
            this.clmnEnterDate,
            this.clmnExitDate,
            this.clmnIsSettled});
            this.grdOwner.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdOwner.GridControl = this.grd;
            this.grdOwner.Name = "grdOwner";
            this.grdOwner.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdOwner.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdOwner.OptionsBehavior.Editable = false;
            this.grdOwner.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdOwner.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdOwner.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdOwner.OptionsView.EnableAppearanceEvenRow = true;
            this.grdOwner.OptionsView.EnableAppearanceOddRow = true;
            this.grdOwner.OptionsView.RowAutoHeight = true;
            this.grdOwner.RowHeight = 50;
            this.grdOwner.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdOwner_RowClick);
            this.grdOwner.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grdOwner_RowCellStyle);
            // 
            // clmnID
            // 
            this.clmnID.Caption = "شناسه";
            this.clmnID.FieldName = "ID";
            this.clmnID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnID.ImageOptions.Image")));
            this.clmnID.MinWidth = 25;
            this.clmnID.Name = "clmnID";
            this.clmnID.Visible = true;
            this.clmnID.VisibleIndex = 0;
            this.clmnID.Width = 94;
            // 
            // clmnNameOfOwner
            // 
            this.clmnNameOfOwner.Caption = "نام و نام خانوادگی";
            this.clmnNameOfOwner.FieldName = "NameOfOwner";
            this.clmnNameOfOwner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnNameOfOwner.ImageOptions.Image")));
            this.clmnNameOfOwner.MinWidth = 25;
            this.clmnNameOfOwner.Name = "clmnNameOfOwner";
            this.clmnNameOfOwner.Visible = true;
            this.clmnNameOfOwner.VisibleIndex = 1;
            this.clmnNameOfOwner.Width = 94;
            // 
            // clmnTelOfOwner
            // 
            this.clmnTelOfOwner.Caption = "شماره همراه";
            this.clmnTelOfOwner.FieldName = "TelOfOwner";
            this.clmnTelOfOwner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnTelOfOwner.ImageOptions.Image")));
            this.clmnTelOfOwner.MinWidth = 25;
            this.clmnTelOfOwner.Name = "clmnTelOfOwner";
            this.clmnTelOfOwner.Visible = true;
            this.clmnTelOfOwner.VisibleIndex = 2;
            this.clmnTelOfOwner.Width = 94;
            // 
            // clmnContainerNumber
            // 
            this.clmnContainerNumber.Caption = "شماره کانتینر";
            this.clmnContainerNumber.FieldName = "ContainerNumber";
            this.clmnContainerNumber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnContainerNumber.ImageOptions.Image")));
            this.clmnContainerNumber.MinWidth = 25;
            this.clmnContainerNumber.Name = "clmnContainerNumber";
            this.clmnContainerNumber.Visible = true;
            this.clmnContainerNumber.VisibleIndex = 3;
            this.clmnContainerNumber.Width = 94;
            // 
            // clmnEnterDate
            // 
            this.clmnEnterDate.Caption = "تاریخ ورود";
            this.clmnEnterDate.FieldName = "EnterDateShamsi";
            this.clmnEnterDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnEnterDate.ImageOptions.Image")));
            this.clmnEnterDate.MinWidth = 25;
            this.clmnEnterDate.Name = "clmnEnterDate";
            this.clmnEnterDate.Visible = true;
            this.clmnEnterDate.VisibleIndex = 4;
            this.clmnEnterDate.Width = 94;
            // 
            // clmnExitDate
            // 
            this.clmnExitDate.Caption = "تاریخ خروج";
            this.clmnExitDate.FieldName = "ExitDateShamsi";
            this.clmnExitDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnExitDate.ImageOptions.Image")));
            this.clmnExitDate.MinWidth = 25;
            this.clmnExitDate.Name = "clmnExitDate";
            this.clmnExitDate.Visible = true;
            this.clmnExitDate.VisibleIndex = 5;
            this.clmnExitDate.Width = 94;
            // 
            // clmnIsSettled
            // 
            this.clmnIsSettled.Caption = "وضعیت مالی";
            this.clmnIsSettled.FieldName = "IsSettled";
            this.clmnIsSettled.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnIsSettled.ImageOptions.Image")));
            this.clmnIsSettled.MinWidth = 25;
            this.clmnIsSettled.Name = "clmnIsSettled";
            this.clmnIsSettled.Visible = true;
            this.clmnIsSettled.VisibleIndex = 6;
            this.clmnIsSettled.Width = 94;
            // 
            // frmOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 578);
            this.Controls.Add(this.grpOwnerInfo);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MinimizeBox = false;
            this.Name = "frmOwner";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "فرم ورود و خروج کانتینر";
            this.Load += new System.EventHandler(this.frmOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOwnerInfo)).EndInit();
            this.grpOwnerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOwner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnShowOwner;
        private DevExpress.XtraBars.BarButtonItem btnInsertOwner;
        private DevExpress.XtraBars.BarButtonItem btnUpdateOwner;
        private DevExpress.XtraBars.BarButtonItem btnDelOwner;
        private DevExpress.XtraBars.BarButtonItem btnReportByName;
        private DevExpress.XtraBars.BarButtonItem btnReturn;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.GroupControl grpOwnerInfo;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grdOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnNameOfOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnTelOfOwner;
        private DevExpress.XtraGrid.Columns.GridColumn clmnContainerNumber;
        private DevExpress.XtraGrid.Columns.GridColumn clmnEnterDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnExitDate;
        private DevExpress.XtraGrid.Columns.GridColumn clmnIsSettled;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
    }
}