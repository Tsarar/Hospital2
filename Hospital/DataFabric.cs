using System;
using System.Collections.Generic;
using Hospital.Database;
using Hospital.Dto;

namespace Hospital
{
    public static class DataFabric
    {
        private static readonly DBConnectorMySQL _connect;

        static DataFabric()
        {
            _connect = new DBConnectorMySQL();
        }

        private static List<string>[] GetAllFields(string table, string fieldNames)
        {
            return _connect.Select(table, fieldNames);
        }

        public static List<UserDto> GetUsers()
        {
            var result = new List<UserDto>();

            var lst = GetAllFields(Properties.MySQLNames.userTableName, Properties.MySQLNames.userFields);
            for (int i = 0; i < lst[0].Count; i++)
            {
                result.Add(new UserDto()
                {
                    User = lst[0][i],
                    Password = lst[1][i],
                    Name = lst[2][i]
                });   
            }

            return result;
        }

        public static List<PeopleDto> GetPeople()
        {
            var result = new List<PeopleDto>();

            var lst = GetAllFields(Properties.MySQLNames.userTableName, Properties.MySQLNames.userFields);
            for (int i = 0; i < lst[0].Count; i++)
            {
                result.Add(new PeopleDto()
                {
                    Id = Convert.ToInt32(lst[0][i]),
                    FirstDate = DateTime.Parse(lst[1][i]),
                    Document = lst[2][i],
                    NumberOfCard = Convert.ToInt32(lst[3][i]),
                    Surname = lst[4][i],
                    Name = lst[5][i],
                    SecondName = lst[6][i],
                    PhoneNumber = lst[7][i],
                    Area = lst[8][i],
                    Description = lst[9][i],
                    Author = lst[10][i]
                });
            }

            return result;
        }
    }
}
