namespace OrbisInjector
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PayloadComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.IpAddressTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.PayloadTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LogMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.CustomPathEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PayloadComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IpAddressTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayloadTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomPathEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PayloadComboBoxEdit
            // 
            this.PayloadComboBoxEdit.Location = new System.Drawing.Point(139, 24);
            this.PayloadComboBoxEdit.Name = "PayloadComboBoxEdit";
            this.PayloadComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PayloadComboBoxEdit.Size = new System.Drawing.Size(163, 20);
            this.PayloadComboBoxEdit.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.IpAddressTextEdit);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.PayloadTextEdit);
            this.groupControl1.Controls.Add(this.PayloadComboBoxEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(307, 80);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Payload";
            // 
            // IpAddressTextEdit
            // 
            this.IpAddressTextEdit.EditValue = "";
            this.IpAddressTextEdit.Location = new System.Drawing.Point(5, 24);
            this.IpAddressTextEdit.Name = "IpAddressTextEdit";
            this.IpAddressTextEdit.Size = new System.Drawing.Size(128, 20);
            this.IpAddressTextEdit.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(222, 50);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 20);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "...";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // PayloadTextEdit
            // 
            this.PayloadTextEdit.EditValue = "C:\\Custom\\File\\Path";
            this.PayloadTextEdit.Location = new System.Drawing.Point(5, 50);
            this.PayloadTextEdit.Name = "PayloadTextEdit";
            this.PayloadTextEdit.Size = new System.Drawing.Size(210, 20);
            this.PayloadTextEdit.TabIndex = 2;
            // 
            // LogMemoEdit
            // 
            this.LogMemoEdit.Location = new System.Drawing.Point(12, 89);
            this.LogMemoEdit.Name = "LogMemoEdit";
            this.LogMemoEdit.Size = new System.Drawing.Size(307, 201);
            this.LogMemoEdit.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 300);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(215, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Inject Payload";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // CustomPathEdit
            // 
            this.CustomPathEdit.Location = new System.Drawing.Point(233, 302);
            this.CustomPathEdit.Name = "CustomPathEdit";
            this.CustomPathEdit.Properties.Caption = "Custom Path?";
            this.CustomPathEdit.Size = new System.Drawing.Size(86, 19);
            this.CustomPathEdit.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 335);
            this.Controls.Add(this.CustomPathEdit);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.LogMemoEdit);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Orbis Payload Injector - v1.0.0.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayloadComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IpAddressTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayloadTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomPathEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit PayloadComboBoxEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit PayloadTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit LogMemoEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit IpAddressTextEdit;
        private DevExpress.XtraEditors.CheckEdit CustomPathEdit;
    }
}

