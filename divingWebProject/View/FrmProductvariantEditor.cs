using divingWebProject.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace divingWebProject.View
{
    public partial class FrmProductvariantEditor : Form
    {
        public DialogResult isOK { get; set; }
        private CNProductvariant _newproductvariant;
        public FrmProductvariantEditor()
        {
            InitializeComponent();
        }
        public CNProductvariant newproductvariant
        {
            get
            {
                if (_newproductvariant == null)
                    _newproductvariant = new CNProductvariant();
              
                    _newproductvariant.fId = Convert.ToInt32(fbId.filedValue);
                _newproductvariant.fcolor = fbColor.SelectedIndex;
                _newproductvariant.fsize = fbSize.SelectedIndex;
                _newproductvariant.fgender = fbGender.SelectedIndex;
                _newproductvariant.fthickness = fbThickness.SelectedIndex;
                _newproductvariant.fstock = Convert.ToInt32(fbstock.filedValue);
                return _newproductvariant;
            }
            set
            {
                _newproductvariant = value;
                fbId.filedValue = _newproductvariant.fId.ToString();
                fbSize.SelectedIndex = _newproductvariant.fsize;
                fbColor.SelectedIndex = _newproductvariant.fcolor;
                fbGender.SelectedIndex = _newproductvariant.fgender;
                fbThickness.SelectedIndex = _newproductvariant.fthickness;
                fbstock.filedValue = _newproductvariant.fstock.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmNew_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {

            this.isOK = DialogResult.OK;
            Close();
        }
    }
}

