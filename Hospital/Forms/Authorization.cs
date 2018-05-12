using Hospital.database;
using Hospital.Forms;
using Hospital.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Authorization : Form
    {
        ComponentsSetting _componentSettings;
        List<UserDto> _users;
        public Authorization()
        {
            InitializeComponent();
            _componentSettings = new ComponentsSetting();
            _users = new List<UserDto>();
        }

       
        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            registrationForm.ShowDialog(this);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            _users = DataFabric.GetUsers();
            if (_users.First(currentUser =>
                    currentUser.Name == LoginTextBox.Text &&
                    currentUser.Password == PasswordTextBox.Text)
                != null)
            {
                People form = new People();
                form.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль!",
                    "Ошибка доступа", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == String.Empty)
                _componentSettings
                    .TextBoxDefaultSetting(LoginTextBox, 
                                           Properties.DefaultsFormsValues
                                           .LoginTextBoxText);
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text))
                _componentSettings.TextBoxEnterSetting(LoginTextBox);
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == String.Empty)
                _componentSettings
                    .TextBoxDefaultSetting(PasswordTextBox,
                                           Properties.DefaultsFormsValues
                                           .PasswordTextBoxText);
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
                _componentSettings.TextBoxEnterSetting(PasswordTextBox);
        }
    }
}
