using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hospital.parser
{
    class TxtConfigParser : IConfigParser
    {
        private readonly Dictionary<string, string> _values = new Dictionary<string, string>();

        public TxtConfigParser(string path)
        {
            ReadFile(path);
        }
        public void ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show(Properties.Messages.Error + @" " + path + @" " + Properties.Messages.notExist);
                return;
            }

            var filestream = new FileStream(path, 
                                            FileMode.Open,
                                            FileAccess.Read);
            var file = new StreamReader(filestream, Encoding.UTF8, true, 128);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                line = line.Trim();
                //except section names
                if (!line.Contains("[") && line != "")
                {
                    var arr = line.Split(':');
                    _values.Add(arr[0].Trim(), arr[1].Trim());
                }
            }
        }

        public string GetSetting(string paramName, string validationRule)
        {
            string pattern;
            //pattern is number
            if (validationRule.ToLower() == "number") pattern = Properties.RegexPatterns.Number;
            //pattern is host
            else if (validationRule.ToLower() == "host") pattern = Properties.RegexPatterns.Host;
            //pattern is string
            else if (validationRule.ToLower() == "string") pattern = Properties.RegexPatterns.String;
            //invalid pattern
            else
            {
                MessageBox.Show(Properties.Messages.Error + @" " + 
                                Properties.Messages.ValidationRuleFor + @" "+
                                paramName +  @" " + 
                                Properties.Messages.isNotDefined + @"!");
                return "";
            }

            //wrong parameter
            if (!_values.ContainsKey(paramName))
            {
                MessageBox.Show(Properties.Messages.Error + @" " + paramName + @" " + Properties.Messages.notExist);
                return "";
            }

            //validation
            if (!Regex.IsMatch(_values[paramName], pattern))
            {
                MessageBox.Show(Properties.Messages.Error + @" " + paramName + @" " + Properties.Messages.invalid);
                return "";
            }

            return _values[paramName];
        }

        public string GetRawSetting(string paramName)
        {
            if (_values.ContainsKey(paramName)) return _values[paramName];
            //nonexistent parameter
            MessageBox.Show(Properties.Messages.Error + @" " + paramName + @" " + Properties.Messages.notExist);
            return "";
        }
    }
}

