namespace Store_Project
{
    partial class frmTariff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTariff));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnShowTariff = new DevExpress.XtraBars.BarButtonItem();
            this.btnInsertTariff = new DevExpress.XtraBars.BarButtonItem();
            this.btnReturn = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateTariff = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelTariff = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory2 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.grpShowTariff = new DevExpress.XtraEditors.GroupControl();
            this.grd2 = new DevExpress.XtraGrid.GridControl();
            this.grdTariff = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnFromDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnTilDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmnDailyCost = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpShowTariff)).BeginInit();
            this.grpShowTariff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTariff)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnShowTariff,
            this.btnInsertTariff,
            this.btnUpdateTariff,
            this.btnDelTariff,
            this.btnReturn});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1,
            this.ribbonPageCategory2});
            this.ribbon.Size = new System.Drawing.Size(969, 209);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.ItemLinks.Add(this.btnShowTariff);
            this.applicationMenu1.ItemLinks.Add(this.btnInsertTariff);
            this.applicationMenu1.ItemLinks.Add(this.btnReturn);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // btnShowTariff
            // 
            this.btnShowTariff.Caption = "نمایش تعرفه ها";
            this.btnShowTariff.Id = 1;
            this.btnShowTariff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnShowTariff.ImageOptions.Image")));
            this.btnShowTariff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnShowTariff.ImageOptions.LargeImage")));
            this.btnShowTariff.Name = "btnShowTariff";
            this.btnShowTariff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowTariff_ItemClick);
            // 
            // btnInsertTariff
            // 
            this.btnInsertTariff.Caption = "افزودن تعرفه";
            this.btnInsertTariff.Id = 2;
            this.btnInsertTariff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertTariff.ImageOptions.Image")));
            this.btnInsertTariff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInsertTariff.ImageOptions.LargeImage")));
            this.btnInsertTariff.Name = "btnInsertTariff";
            this.btnInsertTariff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsertTariff_ItemClick);
            // 
            // btnReturn
            // 
            this.btnReturn.Caption = "بازگشت";
            this.btnReturn.Id = 5;
            this.btnReturn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.Image")));
            this.btnReturn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.ImageOptions.LargeImage")));
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReturn_ItemClick);
            // 
            // btnUpdateTariff
            // 
            this.btnUpdateTariff.Caption = "ویرایش تعرفه";
            this.btnUpdateTariff.Id = 3;
            this.btnUpdateTariff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTariff.ImageOptions.Image")));
            this.btnUpdateTariff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateTariff.ImageOptions.LargeImage")));
            this.btnUpdateTariff.Name = "btnUpdateTariff";
            this.btnUpdateTariff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdateTariff_ItemClick);
            // 
            // btnDelTariff
            // 
            this.btnDelTariff.Caption = "حذف تعرفه";
            this.btnDelTariff.Id = 4;
            this.btnDelTariff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTariff.ImageOptions.Image")));
            this.btnDelTariff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelTariff.ImageOptions.LargeImage")));
            this.btnDelTariff.Name = "btnDelTariff";
            this.btnDelTariff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelTariff_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonPageCategory1.Text = "تعرفه ها";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "نمایش، افزودن، ویرایش و حذف";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowTariff);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "نمایش تعرفه ها";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInsertTariff);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUpdateTariff);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDelTariff);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "افزودن، ویرایش و حذف تعرفه";
            // 
            // ribbonPageCategory2
            // 
            this.ribbonPageCategory2.Name = "ribbonPageCategory2";
            this.ribbonPageCategory2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonPageCategory2.Text = "بازگشت";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "بازگشت به فرم اصلی";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnReturn);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "بازگشت";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 500);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(969, 30);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "نمایش تعرفه ها";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // grpShowTariff
            // 
            this.grpShowTariff.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpShowTariff.CaptionImageOptions.Image")));
            this.grpShowTariff.Controls.Add(this.grd2);
            this.grpShowTariff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShowTariff.Location = new System.Drawing.Point(0, 209);
            this.grpShowTariff.Name = "grpShowTariff";
            this.grpShowTariff.Size = new System.Drawing.Size(969, 291);
            this.grpShowTariff.TabIndex = 2;
            this.grpShowTariff.Text = "اطلاعات تعرفه";
            // 
            // grd2
            // 
            this.grd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd2.Location = new System.Drawing.Point(2, 33);
            this.grd2.MainView = this.grdTariff;
            this.grd2.MenuManager = this.ribbon;
            this.grd2.Name = "grd2";
            this.grd2.Size = new System.Drawing.Size(965, 256);
            this.grd2.TabIndex = 0;
            this.grd2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdTariff});
            // 
            // grdTariff
            // 
            this.grdTariff.Appearance.EvenRow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdTariff.Appearance.EvenRow.Options.UseBackColor = true;
            this.grdTariff.Appearance.OddRow.BackColor = System.Drawing.Color.Lavender;
            this.grdTariff.Appearance.OddRow.Options.UseBackColor = true;
            this.grdTariff.Appearance.Row.Options.UseTextOptions = true;
            this.grdTariff.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdTariff.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmnID,
            this.clmnFromDay,
            this.clmnTilDay,
            this.clmnDailyCost});
            this.grdTariff.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdTariff.GridControl = this.grd2;
            this.grdTariff.Name = "grdTariff";
            this.grdTariff.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdTariff.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grdTariff.OptionsBehavior.Editable = false;
            this.grdTariff.OptionsFind.FindNullPrompt = "جستجو...";
            this.grdTariff.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdTariff.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.grdTariff.OptionsView.EnableAppearanceEvenRow = true;
            this.grdTariff.OptionsView.EnableAppearanceOddRow = true;
            this.grdTariff.RowHeight = 50;
            this.grdTariff.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grdTariff_RowClick);
            // 
            // clmnID
            // 
            this.clmnID.Caption = "شناسه تعرفه";
            this.clmnID.FieldName = "Code";
            this.clmnID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnID.ImageOptions.Image")));
            this.clmnID.MinWidth = 25;
            this.clmnID.Name = "clmnID";
            this.clmnID.Visible = true;
            this.clmnID.VisibleIndex = 0;
            this.clmnID.Width = 94;
            // 
            // clmnFromDay
            // 
            this.clmnFromDay.Caption = "از روز...";
            this.clmnFromDay.FieldName = "FromDay";
            this.clmnFromDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnFromDay.ImageOptions.Image")));
            this.clmnFromDay.MinWidth = 25;
            this.clmnFromDay.Name = "clmnFromDay";
            this.clmnFromDay.Visible = true;
            this.clmnFromDay.VisibleIndex = 1;
            this.clmnFromDay.Width = 94;
            // 
            // clmnTilDay
            // 
            this.clmnTilDay.Caption = "تا روز...";
            this.clmnTilDay.FieldName = "TillDay";
            this.clmnTilDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnTilDay.ImageOptions.Image")));
            this.clmnTilDay.MinWidth = 25;
            this.clmnTilDay.Name = "clmnTilDay";
            this.clmnTilDay.Visible = true;
            this.clmnTilDay.VisibleIndex = 2;
            this.clmnTilDay.Width = 94;
            // 
            // clmnDailyCost
            // 
            this.clmnDailyCost.Caption = "هزینه روزانه (ریال)";
            this.clmnDailyCost.FieldName = "DailyCost";
            this.clmnDailyCost.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clmnDailyCost.ImageOptions.Image")));
            this.clmnDailyCost.MinWidth = 25;
            this.clmnDailyCost.Name = "clmnDailyCost";
            this.clmnDailyCost.Visible = true;
            this.clmnDailyCost.VisibleIndex = 3;
            this.clmnDailyCost.Width = 94;
            // 
            // frmTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 530);
            this.Controls.Add(this.grpShowTariff);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MinimizeBox = false;
            this.Name = "frmTariff";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "فرم تعرفه ها";
            this.Load += new System.EventHandler(this.frmTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpShowTariff)).EndInit();
            this.grpShowTariff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTariff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnShowTariff;
        private DevExpress.XtraBars.BarButtonItem btnInsertTariff;
        private DevExpress.XtraBars.BarButtonItem btnUpdateTariff;
        private DevExpress.XtraBars.BarButtonItem btnDelTariff;
        private DevExpress.XtraBars.BarButtonItem btnReturn;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.GroupControl grpShowTariff;
        private DevExpress.XtraGrid.Columns.GridColumn clmnID;
        private DevExpress.XtraGrid.Columns.GridColumn clmnFromDay;
        private DevExpress.XtraGrid.Columns.GridColumn clmnTilDay;
        private DevExpress.XtraGrid.Columns.GridColumn clmnDailyCost;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        public DevExpress.XtraGrid.GridControl grd2;
        public DevExpress.XtraGrid.Views.Grid.GridView grdTariff;
    }
}