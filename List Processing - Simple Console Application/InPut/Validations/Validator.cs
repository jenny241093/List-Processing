namespace InPut.Validations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Validator
    {
        // As example:
        public static void IsInsertCommand(string command)
        {
            if (command != "ne6to si")
            {
                throw new Exception(/*String.Exception*/);
            }
            //TO DO 
        }
    }
}
