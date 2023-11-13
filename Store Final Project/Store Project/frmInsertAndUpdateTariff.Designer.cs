namespace Store_Project
{
    partial class frmInsertAndUpdateTariff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertAndUpdateTariff));
            this.grpInsertAndUpdateTariff = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertOrUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtDailyCost = new DevExpress.XtraEditors.TextEdit();
            this.txtTillDay = new DevExpress.XtraEditors.TextEdit();
            this.txtFromDay = new DevExpress.XtraEditors.TextEdit();
            this.txtTariffCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblDailyCost = new DevExpress.XtraEditors.LabelControl();
            this.lblTillDay = new DevExpress.XtraEditors.LabelControl();
            this.lblFromDay = new DevExpress.XtraEditors.LabelControl();
            this.lblCodeOfTariff = new DevExpress.XtraEditors.LabelControl();
            this.TariffErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpInsertAndUpdateTariff)).BeginInit();
            this.grpInsertAndUpdateTariff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDailyCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTillDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTariffCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInsertAndUpdateTariff
            // 
            this.grpInsertAndUpdateTariff.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpInsertAndUpdateTariff.CaptionImageOptions.Image")));
            this.grpInsertAndUpdateTariff.Controls.Add(this.btnCancel);
            this.grpInsertAndUpdateTariff.Controls.Add(this.btnInsertOrUpdate);
            this.grpInsertAndUpdateTariff.Controls.Add(this.txtDailyCost);
            this.grpInsertAndUpdateTariff.Controls.Add(this.txtTillDay);
            this.grpInsertAndUpdateTariff.Controls.Add(this.txtFromDay);
            this.grpInsertAndUpdateTariff.Controls.Add(this.txtTariffCode);
            this.grpInsertAndUpdateTariff.Controls.Add(this.labelControl1);
            this.grpInsertAndUpdateTariff.Controls.Add(this.lblDailyCost);
            this.grpInsertAndUpdateTariff.Controls.Add(this.lblTillDay);
            this.grpInsertAndUpdateTariff.Controls.Add(this.lblFromDay);
            this.grpInsertAndUpdateTariff.Controls.Add(this.lblCodeOfTariff);
            this.grpInsertAndUpdateTariff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInsertAndUpdateTariff.Location = new System.Drawing.Point(0, 0);
            this.grpInsertAndUpdateTariff.Name = "grpInsertAndUpdateTariff";
            this.grpInsertAndUpdateTariff.Size = new System.Drawing.Size(423, 236);
            this.grpInsertAndUpdateTariff.TabIndex = 0;
            this.grpInsertAndUpdateTariff.Text = "افزودن یا ویرایش تعرفه";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(65, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 35);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertOrUpdate
            // 
            this.btnInsertOrUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertOrUpdate.ImageOptions.Image")));
            this.btnInsertOrUpdate.Location = new System.Drawing.Point(207, 189);
            this.btnInsertOrUpdate.Name = "btnInsertOrUpdate";
            this.btnInsertOrUpdate.Size = new System.Drawing.Size(136, 35);
            this.btnInsertOrUpdate.TabIndex = 13;
            this.btnInsertOrUpdate.Text = "افزودن یا ویرایش";
            this.btnInsertOrUpdate.Click += new System.EventHandler(this.btnInsertOrUpdate_Click);
            // 
            // txtDailyCost
            // 
            this.txtDailyCost.Location = new System.Drawing.Point(104, 148);
            this.txtDailyCost.Name = "txtDailyCost";
            this.txtDailyCost.Properties.Mask.EditMask = "n0";
            this.txtDailyCost.Size = new System.Drawing.Size(164, 22);
            this.txtDailyCost.TabIndex = 8;
            this.txtDailyCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDailyCost_KeyPress);
            this.txtDailyCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtDailyCost_Validating);
            // 
            // txtTillDay
            // 
            this.txtTillDay.Location = new System.Drawing.Point(44, 96);
            this.txtTillDay.Name = "txtTillDay";
            this.txtTillDay.Properties.MaxLength = 4;
            this.txtTillDay.Size = new System.Drawing.Size(125, 22);
            this.txtTillDay.TabIndex = 7;
            this.txtTillDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTillDay_KeyPress);
            this.txtTillDay.Validating += new System.ComponentModel.CancelEventHandler(this.txtTillDay_Validating);
            // 
            // txtFromDay
            // 
            this.txtFromDay.Location = new System.Drawing.Point(241, 96);
            this.txtFromDay.Name = "txtFromDay";
            this.txtFromDay.Size = new System.Drawing.Size(125, 22);
            this.txtFromDay.TabIndex = 6;
            this.txtFromDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromDay_KeyPress);
            this.txtFromDay.Validating += new System.ComponentModel.CancelEventHandler(this.txtFromDay_Validating);
            // 
            // txtTariffCode
            // 
            this.txtTariffCode.Location = new System.Drawing.Point(104, 50);
            this.txtTariffCode.Name = "txtTariffCode";
            this.txtTariffCode.Size = new System.Drawing.Size(164, 22);
            this.txtTariffCode.TabIndex = 5;
            this.txtTariffCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTariffCode_KeyPress);
            this.txtTariffCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtTariffCode_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(76, 151);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(22, 17);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "ریال";
            // 
            // lblDailyCost
            // 
            this.lblDailyCost.Location = new System.Drawing.Point(274, 151);
            this.lblDailyCost.Name = "lblDailyCost";
            this.lblDailyCost.Size = new System.Drawing.Size(76, 17);
            this.lblDailyCost.TabIndex = 3;
            this.lblDailyCost.Text = "هزینه روزانه: ";
            // 
            // lblTillDay
            // 
            this.lblTillDay.Location = new System.Drawing.Point(175, 99);
            this.lblTillDay.Name = "lblTillDay";
            this.lblTillDay.Size = new System.Drawing.Size(37, 17);
            this.lblTillDay.TabIndex = 2;
            this.lblTillDay.Text = "تا روز: ";
            // 
            // lblFromDay
            // 
            this.lblFromDay.Location = new System.Drawing.Point(372, 99);
            this.lblFromDay.Name = "lblFromDay";
            this.lblFromDay.Size = new System.Drawing.Size(37, 17);
            this.lblFromDay.TabIndex = 1;
            this.lblFromDay.Text = "از روز: ";
            // 
            // lblCodeOfTariff
            // 
            this.lblCodeOfTariff.Location = new System.Drawing.Point(274, 53);
            this.lblCodeOfTariff.Name = "lblCodeOfTariff";
            this.lblCodeOfTariff.Size = new System.Drawing.Size(89, 17);
            this.lblCodeOfTariff.TabIndex = 0;
            this.lblCodeOfTariff.Text = "شناسه تعرفه: ";
            // 
            // TariffErrorProvider
            // 
            this.TariffErrorProvider.ContainerControl = this;
            // 
            // frmInsertAndUpdateTariff
            // 
            this.AcceptButton = this.btnInsertOrUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 236);
            this.Controls.Add(this.grpInsertAndUpdateTariff);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertAndUpdateTariff";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم افزودن یا ویرایش تعرفه ها";
            this.Load += new System.EventHandler(this.frmInsertAndUpdateTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpInsertAndUpdateTariff)).EndInit();
            this.grpInsertAndUpdateTariff.ResumeLayout(false);
            this.grpInsertAndUpdateTariff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDailyCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTillDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTariffCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TariffErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpInsertAndUpdateTariff;
        private DevExpress.XtraEditors.TextEdit txtTariffCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblDailyCost;
        private DevExpress.XtraEditors.LabelControl lblTillDay;
        private DevExpress.XtraEditors.LabelControl lblFromDay;
        private DevExpress.XtraEditors.LabelControl lblCodeOfTariff;
        private DevExpress.XtraEditors.TextEdit txtDailyCost;
        private DevExpress.XtraEditors.TextEdit txtFromDay;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnInsertOrUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider TariffErrorProvider;
        public DevExpress.XtraEditors.TextEdit txtTillDay;
    }
}