namespace InPut
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using InPut.Common;

    public class InputProvider
    {
        public static ICollection<string> ReadLine()
        {
            string initialItems = Regex.Escape(Console.ReadLine());
            char[] delimiter = new char[] { Chars.Space };
            StringSplitOptions option = StringSplitOptions.RemoveEmptyEntries;

            return initialItems.Split(delimiter, option).ToList();
        }

        public static void ReadNextLines(string command)
        {
            while (command != Strings.EndCommand)
            {
                //Console.ReadLine();
            }
        }
    }
}
