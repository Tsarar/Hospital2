using System;
using System.Linq;
using System.Windows.Forms;
using Hospital.Database;
using Hospital.Helper;

namespace Hospital
{
    public partial class Authorization : Form
    {
        private readonly DBConnectorMySQL _connect;
        private readonly ComponentsSetting _componentSettings;

        public Authorization()
        {
            InitializeComponent();

            _connect = new DBConnectorMySQL();
            _componentSettings = new ComponentsSetting();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new Registration(_connect, _componentSettings);
            registrationForm.ShowDialog(this);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            var users = DataFabric.GetUsers();
            var currentUser = users.FirstOrDefault(user => user.Name == LoginTextBox.Text &&
                                                           user.Password == PasswordTextBox.Text);
            if (currentUser == null)
            {
                MessageBox.Show(@"Неправильный логин или пароль!",
                                @"Ошибка доступа",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
                
            }

            var form = new People();
            form.Show();
        }

        #region ComponentSetting

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == Properties.DefaultsFormsValues.LoginTextBoxText)
            {
                _componentSettings.TextBoxEnterSetting(LoginTextBox);
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == Properties.DefaultsFormsValues.PasswordTextBoxText)
            {
                _componentSettings.TextBoxEnterSetting(PasswordTextBox);
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text))
            {
                _componentSettings.TextBoxDefaultSetting(LoginTextBox,
                    Properties.DefaultsFormsValues.LoginTextBoxText);

            }
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                _componentSettings.TextBoxDefaultSetting(PasswordTextBox,
                    Properties.DefaultsFormsValues.PasswordTextBoxText);
            }
        }
        #endregion
        
    }
}
