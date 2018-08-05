using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Hospital.Database;
using Hospital.Dto;
using Hospital.Helper;

namespace Hospital
{
    public partial class Registration : Form
    {
        private readonly DBConnectorMySQL _connect;
        public Registration(DBConnectorMySQL connect)
        {
            InitializeComponent();

            _connect = connect;

            NameTextBox.GotFocus += RemovePlaceholder;
            NameTextBox.LostFocus += AddPlaceholderName; 

            LoginTextBox.GotFocus += RemovePlaceholder;
            LoginTextBox.LostFocus += AddPlaceholderLogin;

            PasswordTextBox.GotFocus += RemovePlaceholder;
            PasswordTextBox.LostFocus += AddPlaceholderPassword;

            CodeTextBox.GotFocus += RemovePlaceholder;
            CodeTextBox.LostFocus += AddPlaceholderCode;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            //todo check regex
            var allUsers = DataFabric.GetUsers();

            var registerUser = allUsers.FirstOrDefault(currentUser => currentUser.Name == LoginTextBox.Text.Trim());

            if (registerUser != null)
            {
                MessageBox.Show(@"Такой пользователь уже существует", 
                                @"Ошибка регистрации", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                return;
            }

            var user = allUsers.FirstOrDefault(currentUser => currentUser.User == "password" &&
                                                              currentUser.Password == CodeTextBox.Text.Trim());
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
                Name = LoginTextBox.Text.Trim(),
                User = NameTextBox.Text.Trim(),
                Password = PasswordTextBox.Text.Trim()
            };

            string values = $"'{newUser.User}', '{newUser.Password}', '{newUser.Name}'";

            _connect.Insert(Properties.MySQLNames.userTableName, 
                            Properties.MySQLNames.userFields, 
                            values);//todo maybe add filling authorization form by this values
        }



        #region ComponentSettings

        public void RemovePlaceholder(object sender, EventArgs e)
        {
            if (((TextBox) sender).ForeColor == Color.DimGray)
            {
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        public void AddPlaceholderName(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                ((TextBox)sender).ForeColor = Color.DimGray;
                ((TextBox)sender).Text = "Введите Ваше имя";
            }
        }

        public void AddPlaceholderLogin(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                ((TextBox)sender).ForeColor = Color.DimGray;
                ((TextBox)sender).Text = "Введите Ваш логин";
            }
        }

        public void AddPlaceholderPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox) sender).Text))
            {
                ((TextBox)sender).ForeColor = Color.DimGray;
                ((TextBox)sender).Text = "Введите Ваш пароль";
            }
        }

        public void AddPlaceholderCode(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                ((TextBox)sender).ForeColor = Color.DimGray;
                ((TextBox)sender).Text = "Введите секретный код";
            }
        }

        #endregion
    }
}
