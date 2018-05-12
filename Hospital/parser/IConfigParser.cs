namespace Hospital.parser
{
    interface IConfigParser
    {
        //get values from file and store them into inner container
        void ReadFile(string path);

        //return validated value
        string GetSetting(string name, string validationRule);

        //return unvalidated value
        string GetRawSetting(string name);
    }
}
