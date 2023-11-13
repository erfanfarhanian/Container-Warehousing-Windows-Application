namespace Store_Project
{
    partial class frmInsertAndUpdateOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertAndUpdateOwner));
            this.grpInsertAndUpdateOwner = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnInsertOrEditOwner = new DevExpress.XtraEditors.SimpleButton();
            this.rdNotSettled = new System.Windows.Forms.RadioButton();
            this.rdSettled = new System.Windows.Forms.RadioButton();
            this.txtExitDate = new Atf.UI.DateTimeSelector();
            this.txtEnterDate = new Atf.UI.DateTimeSelector();
            this.txtContainerNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtTelOfOwner = new DevExpress.XtraEditors.TextEdit();
            this.txtNameOfOwner = new DevExpress.XtraEditors.TextEdit();
            this.lblIsSettled = new DevExpress.XtraEditors.LabelControl();
            this.lblExitDate = new DevExpress.XtraEditors.LabelControl();
            this.lblEnterDate = new DevExpress.XtraEditors.LabelControl();
            this.lblContainerNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblTelOfOwner = new DevExpress.XtraEditors.LabelControl();
            this.lblNameOfOwner = new DevExpress.XtraEditors.LabelControl();
            this.ContinerErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grpInsertAndUpdateOwner)).BeginInit();
            this.grpInsertAndUpdateOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContainerNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelOfOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOfOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContinerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInsertAndUpdateOwner
            // 
            this.grpInsertAndUpdateOwner.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpInsertAndUpdateOwner.CaptionImageOptions.Image")));
            this.grpInsertAndUpdateOwner.Controls.Add(this.btnCancel);
            this.grpInsertAndUpdateOwner.Controls.Add(this.btnInsertOrEditOwner);
            this.grpInsertAndUpdateOwner.Controls.Add(this.rdNotSettled);
            this.grpInsertAndUpdateOwner.Controls.Add(this.rdSettled);
            this.grpInsertAndUpdateOwner.Controls.Add(this.txtExitDate);
            this.grpInsertAndUpdateOwner.Controls.Add(this.txtEnterDate);
            this.grpInsertAndUpdateOwner.Controls.Add(this.txtContainerNumber);
            this.grpInsertAndUpdateOwner.Controls.Add(this.txtTelOfOwner);
            this.grpInsertAndUpdateOwner.Controls.Add(this.txtNameOfOwner);
            this.grpInsertAndUpdateOwner.Controls.Add(this.lblIsSettled);
            this.grpInsertAndUpdateOwner.Controls.Add(this.lblExitDate);
            this.grpInsertAndUpdateOwner.Controls.Add(this.lblEnterDate);
            this.grpInsertAndUpdateOwner.Controls.Add(this.lblContainerNumber);
            this.grpInsertAndUpdateOwner.Controls.Add(this.lblTelOfOwner);
            this.grpInsertAndUpdateOwner.Controls.Add(this.lblNameOfOwner);
            this.grpInsertAndUpdateOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInsertAndUpdateOwner.Location = new System.Drawing.Point(0, 0);
            this.grpInsertAndUpdateOwner.Name = "grpInsertAndUpdateOwner";
            this.grpInsertAndUpdateOwner.Size = new System.Drawing.Size(676, 252);
            this.grpInsertAndUpdateOwner.TabIndex = 0;
            this.grpInsertAndUpdateOwner.Text = "افزودن یا ویرایش";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(159, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 39);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "بازگشت";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertOrEditOwner
            // 
            this.btnInsertOrEditOwner.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertOrEditOwner.ImageOptions.Image")));
            this.btnInsertOrEditOwner.Location = new System.Drawing.Point(304, 194);
            this.btnInsertOrEditOwner.Name = "btnInsertOrEditOwner";
            this.btnInsertOrEditOwner.Size = new System.Drawing.Size(139, 39);
            this.btnInsertOrEditOwner.TabIndex = 13;
            this.btnInsertOrEditOwner.Text = "افزودن یا ویرایش";
            this.btnInsertOrEditOwner.Click += new System.EventHandler(this.btnInsertOrEditOwner_Click);
            // 
            // rdNotSettled
            // 
            this.rdNotSettled.AutoSize = true;
            this.rdNotSettled.Checked = true;
            this.rdNotSettled.Location = new System.Drawing.Point(126, 154);
            this.rdNotSettled.Name = "rdNotSettled";
            this.rdNotSettled.Size = new System.Drawing.Size(63, 21);
            this.rdNotSettled.TabIndex = 12;
            this.rdNotSettled.TabStop = true;
            this.rdNotSettled.Text = "نشده";
            this.rdNotSettled.UseVisualStyleBackColor = true;
            // 
            // rdSettled
            // 
            this.rdSettled.AutoSize = true;
            this.rdSettled.Location = new System.Drawing.Point(52, 154);
            this.rdSettled.Name = "rdSettled";
            this.rdSettled.Size = new System.Drawing.Size(58, 21);
            this.rdSettled.TabIndex = 11;
            this.rdSettled.Text = "شده";
            this.rdSettled.UseVisualStyleBackColor = true;
            // 
            // txtExitDate
            // 
            this.txtExitDate.Location = new System.Drawing.Point(40, 106);
            this.txtExitDate.Name = "txtExitDate";
            this.txtExitDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExitDate.Size = new System.Drawing.Size(168, 24);
            this.txtExitDate.TabIndex = 10;
            this.txtExitDate.UsePersianFormat = true;
            // 
            // txtEnterDate
            // 
            this.txtEnterDate.Location = new System.Drawing.Point(40, 55);
            this.txtEnterDate.Name = "txtEnterDate";
            this.txtEnterDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEnterDate.Size = new System.Drawing.Size(168, 24);
            this.txtEnterDate.TabIndex = 9;
            this.txtEnterDate.UsePersianFormat = true;
            // 
            // txtContainerNumber
            // 
            this.txtContainerNumber.Location = new System.Drawing.Point(336, 151);
            this.txtContainerNumber.Name = "txtContainerNumber";
            this.txtContainerNumber.Properties.MaxLength = 10;
            this.txtContainerNumber.Size = new System.Drawing.Size(179, 22);
            this.txtContainerNumber.TabIndex = 8;
            this.txtContainerNumber.Validated += new System.EventHandler(this.txtContainerNumber_Validated);
            // 
            // txtTelOfOwner
            // 
            this.txtTelOfOwner.Location = new System.Drawing.Point(336, 103);
            this.txtTelOfOwner.Name = "txtTelOfOwner";
            this.txtTelOfOwner.Properties.MaxLength = 11;
            this.txtTelOfOwner.Size = new System.Drawing.Size(179, 22);
            this.txtTelOfOwner.TabIndex = 7;
            this.txtTelOfOwner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelOfOwner_KeyPress);
            this.txtTelOfOwner.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelOfOwner_Validating);
            // 
            // txtNameOfOwner
            // 
            this.txtNameOfOwner.Location = new System.Drawing.Point(336, 57);
            this.txtNameOfOwner.Name = "txtNameOfOwner";
            this.txtNameOfOwner.Properties.MaxLength = 100;
            this.txtNameOfOwner.Size = new System.Drawing.Size(179, 22);
            this.txtNameOfOwner.TabIndex = 6;
            this.txtNameOfOwner.Validating += new System.ComponentModel.CancelEventHandler(this.txtNameOfOwner_Validating);
            // 
            // lblIsSettled
            // 
            this.lblIsSettled.Location = new System.Drawing.Point(214, 154);
            this.lblIsSettled.Name = "lblIsSettled";
            this.lblIsSettled.Size = new System.Drawing.Size(46, 17);
            this.lblIsSettled.TabIndex = 5;
            this.lblIsSettled.Text = "تسویه: ";
            // 
            // lblExitDate
            // 
            this.lblExitDate.Location = new System.Drawing.Point(214, 106);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.Size = new System.Drawing.Size(70, 17);
            this.lblExitDate.TabIndex = 4;
            this.lblExitDate.Text = "تاریخ خروج: ";
            // 
            // lblEnterDate
            // 
            this.lblEnterDate.Location = new System.Drawing.Point(214, 60);
            this.lblEnterDate.Name = "lblEnterDate";
            this.lblEnterDate.Size = new System.Drawing.Size(64, 17);
            this.lblEnterDate.TabIndex = 3;
            this.lblEnterDate.Text = "تاریخ ورود: ";
            // 
            // lblContainerNumber
            // 
            this.lblContainerNumber.Location = new System.Drawing.Point(521, 154);
            this.lblContainerNumber.Name = "lblContainerNumber";
            this.lblContainerNumber.Size = new System.Drawing.Size(88, 17);
            this.lblContainerNumber.TabIndex = 2;
            this.lblContainerNumber.Text = "شماره کانتینر: ";
            // 
            // lblTelOfOwner
            // 
            this.lblTelOfOwner.Location = new System.Drawing.Point(521, 106);
            this.lblTelOfOwner.Name = "lblTelOfOwner";
            this.lblTelOfOwner.Size = new System.Drawing.Size(86, 17);
            this.lblTelOfOwner.TabIndex = 1;
            this.lblTelOfOwner.Text = "شماره همراه: ";
            // 
            // lblNameOfOwner
            // 
            this.lblNameOfOwner.Location = new System.Drawing.Point(521, 60);
            this.lblNameOfOwner.Name = "lblNameOfOwner";
            this.lblNameOfOwner.Size = new System.Drawing.Size(113, 17);
            this.lblNameOfOwner.TabIndex = 0;
            this.lblNameOfOwner.Text = "نام و نام خانوادگی: ";
            // 
            // ContinerErrorProvider
            // 
            this.ContinerErrorProvider.ContainerControl = this;
            // 
            // frmInsertAndUpdateOwner
            // 
            this.AcceptButton = this.btnInsertOrEditOwner;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 252);
            this.Controls.Add(this.grpInsertAndUpdateOwner);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsertAndUpdateOwner";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فرم افزودن و ویرایش کانتینرها";
            this.Load += new System.EventHandler(this.frmInsertAndUpdateOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpInsertAndUpdateOwner)).EndInit();
            this.grpInsertAndUpdateOwner.ResumeLayout(false);
            this.grpInsertAndUpdateOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContainerNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelOfOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOfOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContinerErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpInsertAndUpdateOwner;
        private DevExpress.XtraEditors.LabelControl lblIsSettled;
        private DevExpress.XtraEditors.LabelControl lblExitDate;
        private DevExpress.XtraEditors.LabelControl lblEnterDate;
        private DevExpress.XtraEditors.LabelControl lblContainerNumber;
        private DevExpress.XtraEditors.LabelControl lblTelOfOwner;
        private DevExpress.XtraEditors.LabelControl lblNameOfOwner;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnInsertOrEditOwner;
        private System.Windows.Forms.RadioButton rdNotSettled;
        private System.Windows.Forms.RadioButton rdSettled;
        private Atf.UI.DateTimeSelector txtExitDate;
        private Atf.UI.DateTimeSelector txtEnterDate;
        private DevExpress.XtraEditors.TextEdit txtContainerNumber;
        private DevExpress.XtraEditors.TextEdit txtTelOfOwner;
        private DevExpress.XtraEditors.TextEdit txtNameOfOwner;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider ContinerErrorProvider;
    }
}