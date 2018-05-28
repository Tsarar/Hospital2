using System;
using System.Windows.Forms;
using System.Linq;
using Hospital.Database;
using Hospital.Dto;
using Hospital.Helper;

namespace Hospital
{
    public partial class Registration : Form
    {
        private readonly ComponentsSetting _componentsSetting;
        private readonly DBConnectorMySQL _DBaccess;
        public Registration()
        {
            InitializeComponent();

            _DBaccess = new DBConnectorMySQL();
            _componentsSetting = new ComponentsSetting();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var allUsers = DataFabric.GetUsers();

            var registerUser = allUsers.FirstOrDefault(currentUser => currentUser.Name == LoginTextBox.Text &&
                                                                    currentUser.User == NameTextBox.Text);


            if (registerUser != null)
            {
                MessageBox.Show(@"Такой пользователь уже существует", 
                                @"Ошибка регистрации", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }

            var user = allUsers.FirstOrDefault(currentUser => currentUser.Name == "admin" &&
                                                              currentUser.Password == CodeTextBox.Text);
            if (user == null)
            {
                MessageBox.Show(@"Неверный код!",
                                @"Ошибка регистрации",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var newUser = new UserDto()
            {
                Name = LoginTextBox.Text,
                User = NameTextBox.Text,
                Password = PasswordTextBox.Text
            };

            string values = $"'{newUser.User}', '{newUser.Password}', '{newUser.Name}'";

            _DBaccess.Insert(Properties.MySQLNames.userTableName, 
                             Properties.MySQLNames.userFields, 
                             values);//todo maybe add filling authorization form by this values
        }



        #region ComponentSettings
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text))
            {
                _componentsSetting.TextBoxDefaultSetting(NameTextBox,
                                                         Properties.DefaultsFormsValues.NameTextBoxText);
            }
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text))
            {
                _componentsSetting.TextBoxDefaultSetting(LoginTextBox,
                                                         Properties.DefaultsFormsValues.LoginTextBoxText);
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                _componentsSetting.TextBoxDefaultSetting(PasswordTextBox,
                                                         Properties.DefaultsFormsValues.PasswordTextBoxText);
            }
        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text))
            {
                _componentsSetting.TextBoxEnterSetting(NameTextBox);
            }
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text))
            {
                _componentsSetting.TextBoxEnterSetting(LoginTextBox);
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                _componentsSetting.TextBoxEnterSetting(PasswordTextBox);
            }
        }

        #endregion


    }
}
