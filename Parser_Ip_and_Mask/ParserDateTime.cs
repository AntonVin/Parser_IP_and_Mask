using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Parser_Ip_and_Mask
{
    public static class ParserDateTime
    {
            public static DateTime  Parse(string s)
            {
                var reg = new Regex(@"(?<month>[A-Za-z]{3})[-]+(?<day>\d+)[-]+(?<hour>\d+)[-]+(?<min>\d+)[-]+(?<sec>\d+).(?<ms>\d+)");
                var match = reg.Match(s);
                if (!match.Success)
                    throw new Exception("Неизвестный формат даты. Необходим формат: MMM-dd-hh-mm-ss.ms");

                int year = 2024;// т.к. год не указывается в строке s, заранее укажем какой-то высокосный год(2024, например)
                int month = 1+Array.IndexOf(
                    new string[] { "jan", "feb", "mar", "apr", "may","jun", "jul", "aug", "sep", "oct", "nov", "dec" },
                    match.Groups["month"].ToString().ToLower());
                int day = int.Parse(match.Groups["day"].Value);
                int hour = int.Parse(match.Groups["hour"].Value);
                int min = int.Parse(match.Groups["min"].Value);
                int sec = int.Parse(match.Groups["sec"].Value);
                int ms = int.Parse(match.Groups["ms"].Value);

                return new DateTime(year, month, day, hour, min, sec, ms);
            }
    }
}
