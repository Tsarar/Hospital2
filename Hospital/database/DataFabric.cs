using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.database
{
    static class DataFabric
    {
        static readonly DBConnectorMySQL Connect = new DBConnectorMySQL();

        private static List<string>[] GetAllFields(string table, string fieldNames)
        {
            return Connect.Select(table, fieldNames);
        }

        public static List<UserDto> GetUsers()
        {
            List<UserDto> result = new List<UserDto>();

            List<string>[] lst = GetAllFields(Properties.MySQLNames.userTableName, Properties.MySQLNames.userFields);
            for (int i = 0; i < lst[0].Count; i++)
            {
                result.Add(new UserDto(lst[0][i], lst[1][i], lst[2][i]));   
            }

            return result;
        }
    }
}
