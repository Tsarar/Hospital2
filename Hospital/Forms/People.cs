using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Helper;

namespace Hospital
{
    public partial class People : Form
    {
        private ComponentsSetting _componentsSetting;
        
        public People()
        {
            InitializeComponent();
            _componentsSetting = new ComponentsSetting();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == String.Empty)
                _componentsSetting
                    .TextBoxDefaultSetting(SearchTextBox,
                        Properties.DefaultsFormsValues
                            .Search);
        }

        
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchTextBox.Text))
                _componentsSetting.TextBoxEnterSetting(SearchTextBox);
        }
    }
}
