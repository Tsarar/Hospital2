using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.database;
using Hospital.Helper;

namespace Hospital.Forms
{
    public partial class Registration : Form
    {
        private UserDto _newUser;
        private ComponentsSetting _componentsSetting;
        private DBConnectorMySQL _DBaccess;
     

        public Registration()
        {
            InitializeComponent();
            _newUser = new UserDto();
            _DBaccess = new DBConnectorMySQL();
            _componentsSetting =  new ComponentsSetting();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<UserDto> allUsers = DataFabric.GetUsers();

            if (allUsers.First(currentUser =>
                    currentUser.Name == "admin" &&
                    currentUser.Password == CodeTextBox.Text)
                != null)
            {
                _newUser.Name = LoginTextBox.Text;
                _newUser.User = NameTextBox.Text;
                _newUser.Password = PasswordTextBox.Text;
            }

            // dbname????? NO _DBaccess.Insert();
        }



        #region ComponentSettings
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text == String.Empty)
                _componentsSetting
                    .TextBoxDefaultSetting(NameTextBox,
                        Properties.DefaultsFormsValues
                            .NameTextBoxText);
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == String.Empty)
                _componentsSetting
                    .TextBoxDefaultSetting(LoginTextBox,
                        Properties.DefaultsFormsValues
                            .LoginTextBoxText);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == String.Empty)
                _componentsSetting
                    .TextBoxDefaultSetting(PasswordTextBox,
                        Properties.DefaultsFormsValues
                            .PasswordTextBoxText);
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text))
                _componentsSetting.TextBoxEnterSetting(NameTextBox);
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text))
                _componentsSetting.TextBoxEnterSetting(LoginTextBox);
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
                _componentsSetting.TextBoxEnterSetting(PasswordTextBox);
        }

        #endregion


    }
}
