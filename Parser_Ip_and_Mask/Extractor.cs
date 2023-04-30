using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parser_Ip_and_Mask
{
    internal static class Extractor
    {
        public static void ExtractIpAndMask(string path,DataGridView dgv,TextBox log)
        {
            var dirs = Directory.GetDirectories(path);

            foreach (var dir in dirs)
            {
                for (int i = 1; i <= 2; i++)
                {
                    var lastFile = GetLastFile(dir, $"*-rt-*-{i}-*");
                    if (lastFile is null)
                        log.AppendText($"{dir} не содержит файла с роутером №{i}" + Environment.NewLine);
                    else
                    { 
                        var matches = ParseFromFile(lastFile, 
                            @"forwarding\sTM_PS\s+ip\s+address\s(?<ip>\d+.\d+.\d+.\d+)\s+(?<mask>\d+.\d+.\d+.\d+)");
                        foreach (Match match in matches)
                        {
                            dgv.Rows.Add(
                                dir.Split("\\")[^1],// имя станции
                                match.Groups["ip"].Value,
                                match.Groups["mask"].Value
                            );
                        }
                     }
                }
            }
        }

        private static string? GetLastFile(string dir,string pattern)=>
            Directory.GetFiles(dir, pattern).
                        Where(f => !f.Contains("SM")).
                        MaxBy(f => File.GetLastWriteTime(f));

        private static MatchCollection ParseFromFile(string fileName,string regularExpr)
        {
            using (var reader = new StreamReader(fileName))
            {
                string content = reader.ReadToEnd();
                var reg = new Regex(regularExpr);
                return reg.Matches(content);
            }
        }
    }
}
