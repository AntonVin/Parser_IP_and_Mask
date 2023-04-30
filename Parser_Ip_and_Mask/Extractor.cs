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
        public static void ExtractIpandMask(string path,DataGridView dgv,TextBox log)
        {
            var dirs = Directory.GetDirectories(path);

            foreach (var dir in dirs)
            {
                for (int i = 1; i <= 2; i++)
                {
                    var lastFile = Directory.GetFiles(dir, $"*-rt-*-{i}-*").
                        Where(f => !f.Contains("SM")).
                        MaxBy(f => File.GetLastWriteTime(f));
                    if (lastFile is null)
                        log.AppendText($"{dir} не содержит файла с роутером №{i}" + Environment.NewLine);
                    else
                    { 
                            var matches = ParseFromFile(lastFile);

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

        private static MatchCollection ParseFromFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                string content = reader.ReadToEnd();
                var reg = new Regex(@"forwarding\sTM_PS\s+ip\s+address\s(?<ip>\d+.\d+.\d+.\d+)\s+(?<mask>\d+.\d+.\d+.\d+)");
                return reg.Matches(content);
            }
        }
    }
}
