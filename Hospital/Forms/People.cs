using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.data_models;
using Hospital.Helper;

namespace Hospital
{
    public partial class People : Form
    {
        private ComponentsSetting _componentsSetting;
        private List<PeopleDto> _peopleData;
        
        public People()
        {
            InitializeComponent();
            _componentsSetting = new ComponentsSetting();
            _peopleData = new List<PeopleDto>();
        }

        private void InitializeDataGrid(List<PeopleDto> data)
        {
            dgvPeople.Rows.Clear();
            data.ForEach(current => dgvPeople.Rows.Add(current.FirstDate, current.Document,
                                                        current.NumberOfCard, current.Surname, current.Name, current.SecondName,
                                                        current.PhoneNumber, current.District, current.Comment, current.Author));
        }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Focused)
      
                    {
                        InitializeDataGrid(_peopleData.Where(current =>
                           current.Surname.Contains(SearchTextBox.Text)
                        ).ToList());
                    }
                
        }

        
        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchTextBox.Text))
                _componentsSetting.TextBoxEnterSetting(SearchTextBox);
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {

        }

        private void SearchDelButton_Click(object sender, EventArgs e)
        {
            if (SearchTextBox.Text != String.Empty)
            {
                _componentsSetting
                    .TextBoxDefaultSetting(SearchTextBox,
                        Properties.DefaultsFormsValues
                            .Search);
            }

            InitializeDataGrid(_peopleData);
        }

        private void People_Load(object sender, EventArgs e)
        {

        }
    }
}
