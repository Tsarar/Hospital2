using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.data_models
{
    class PeopleDto
    {
        public DateTime FirstDate { set; get; }
        public string Document { set; get; }
        public int NumberOfCard { set; get; }
        public string Surname { set; get; }
        public string Name { set; get; }
        public string SecondName { set; get; }
        public int PhoneNumber { set; get; }
        public string District { set; get; }
        public string Comment { set; get; }
        public string Author { set; get; }
    }
}
