using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TokenEditTest {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitTokenEdit();
        }
        void InitTokenEdit() {
            tokenEdit.Properties.CustomDropDownControl = new CustomTokenEditDropDownControl();
            for(int i = 0; i < 20; i++) {
                string desc = string.Format("Token{0}", i.ToString());
                tokenEdit.Properties.Tokens.Add(new TokenEditToken(desc, desc));
            }
        }
        void OnTokenEditValidateToken(object sender, TokenEditValidateTokenEventArgs e) {
            e.Value = e.Description;
            e.IsValid = true;
        }
        void OnTokenEditValueChanged(object sender, EventArgs e) {
            Text = ((TokenEdit)sender).EditValue.ToString();
        }
    }
}
