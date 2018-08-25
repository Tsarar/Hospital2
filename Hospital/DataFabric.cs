using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            try
            {
                return _connect.Select(table, fieldNames);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<UserDto> GetUsers()
        {
            var result = new List<UserDto>();

            var lst = GetAllFields(Properties.MySQLNames.userTableName, "*");
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

        #region people

        public static void UpdatePeople(PeopleDto people)
        {
            UpdatePeople(new List<PeopleDto> { people });
        }

        public static void UpdatePeople(IEnumerable<PeopleDto> peopleList)
        {
            foreach(var guy in peopleList)
            {
                try
                {
                    var values = $"{guy.Id}, " +
                                 $"{guy.FirstDate}, " +
                                 $"{guy.Document}, " +
                                 $"{guy.NumberOfCard}, " +
                                 $"{guy.Surname}, " +
                                 $"{guy.Name}, " +
                                 $"{guy.SecondName}, " +
                                 $"{guy.PhoneNumber}, " +
                                 $"{guy.Area}, " +
                                 $"{guy.Description}," +
                                 $"{guy.Author}";

                    _connect.Update(Properties.MySQLNames.cardsTableName,
                                    values,
                                    $"id={guy.Id}");
                }
                catch(Exception ex)
                {
                    throw new Exception($"Unexpected error: {ex.Message}, Id = {guy.Id}");
                }
            }
        }

        public static void InsertPeople(PeopleDto people)
        {
            InsertPeople(new List<PeopleDto> { people });
        }

        public static void InsertPeople(IEnumerable<PeopleDto> peopleList)
        {
            foreach (var guy in peopleList)
            {
                try
                {
                    var values = $"{guy.Id}, " +
                                 $"{guy.FirstDate}, " +
                                 $"{guy.Document}, " +
                                 $"{guy.NumberOfCard}, " +
                                 $"{guy.Surname}, " +
                                 $"{guy.Name}, " +
                                 $"{guy.SecondName}, " +
                                 $"{guy.PhoneNumber}, " +
                                 $"{guy.Area}, " +
                                 $"{guy.Description}," +
                                 $"{guy.Author}";

                    _connect.Insert(Properties.MySQLNames.cardsTableName,
                                    Properties.MySQLNames.cardsFields,
                                    values);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Unexpected error: {ex.Message}, Id = {guy.Id}");
                }
            }
        }

        public static void DeletePeople(string id)
        {
            DeletePeople(new List<string> { id });
        }

        public static void DeletePeople(IEnumerable<string> idList)
        {
            foreach (var id in idList)
            {
                try
                {
                    _connect.Delete(Properties.MySQLNames.cardsTableName,
                                    $"id={id}");
                }
                catch (Exception ex)
                {
                    throw new Exception($"Unexpected error: {ex.Message}, Id = {id}");
                }
            }
        }

        public static List<PeopleDto> GetPeople()
        {
            var result = new List<PeopleDto>();

            var lst = GetAllFields(Properties.MySQLNames.cardsTableName, "*");
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

        #endregion
    }
}
