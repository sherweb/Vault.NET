﻿using System.Collections.Generic;
using System.Linq;

namespace Vault.Util
{
    public class StringUtil
    {
        public static List<string> CsvStringToList(string input)
        {
            return input.Split(',').ToList();
        }

        public static string ListToCsvString(List<string> input)
        {
            return input == null ? null : string.Join(",", input);
        }
    }
}
