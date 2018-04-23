namespace TokenEditTest {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tokenEdit = new DevExpress.XtraEditors.TokenEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenEdit
            // 
            this.tokenEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenEdit.Location = new System.Drawing.Point(12, 50);
            this.tokenEdit.Name = "tokenEdit";
            this.tokenEdit.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tokenEdit.Properties.Separators.AddRange(new string[] {
            ",",
            " "});
            this.tokenEdit.Properties.ShowSeparators = false;
            this.tokenEdit.Properties.ValidationRules = ((DevExpress.XtraEditors.TokenEditValidationRules)((DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnLostFocus | DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnSeparatorInput)));
            this.tokenEdit.Size = new System.Drawing.Size(453, 20);
            this.tokenEdit.TabIndex = 0;
            this.tokenEdit.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.OnTokenEditValidateToken);
            this.tokenEdit.EditValueChanged += new System.EventHandler(this.OnTokenEditValueChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 109);
            this.Controls.Add(this.tokenEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TokenEdit tokenEdit;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

