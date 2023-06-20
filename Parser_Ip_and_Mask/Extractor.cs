using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Parser_Ip_and_Mask
{
    internal static class Extractor
    {
        public static void ExtractDataToTable(string path,DataGridView dgv,TextBox log)
        {
            var dirs = GetDirectories(path);

            foreach (var dir in dirs)
            {
                for (int i = 1; i <= 2; i++)
                {
                    var lastFile = GetLastFile(dir, $"*-rt-*-{i}-*");
                    if (lastFile is null)
                        log.AppendText($"{dir} не содержит файла с роутером №{i}" + Environment.NewLine);
                    else
                    {
                        FillTableFromFile(dgv, dir, lastFile);
                        //   var matches = ParseFromFile(lastFile, 
                        //       $@"forwarding\s+{vrf}\s+ip\s+address\s(?<ip>\d+.\d+.\d+.\d+)\s+(?<mask>\d+.\d+.\d+.\d+)");
                        //   foreach (Match match in matches)
                        //   {
                        //       dgv.Rows.Add(
                        //           dir.Split("\\")[^1],// имя станции
                        //           match.Groups["ip"].Value,
                        //           match.Groups["mask"].Value
                        //       );
                        //   }
                    }
                }
            }
        }

        private static void FillTableFromFile(DataGridView dgv, string dir, string? lastFile)
        {
            string nameStation = dir.Split("\\")[^1];

            string nameInterface = "";
            string ip = "";
            string mask = "";
            string vrf = "";
            string shootdown = "";

            using (var reader = new StreamReader(lastFile))
            {
                string? line;
                var regStartBlockInterface = new Regex(@"^interface\s+(?<nameInterface>\S+)", RegexOptions.IgnoreCase);
                bool InBlock = false;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!InBlock)
                    {
                        var match = regStartBlockInterface.Match(line);
                        if (match.Success)
                        {
                            InBlock = true;
                            nameInterface = match.Groups["nameInterface"].Value;
                        }
                    }
                    else
                    {
                        if (line[0] == ' ')
                        {
                            var matchVRF = new Regex(@"\s+ip\s+vrf\s+forwarding\s+(?<vrf>\w+)").Match(line);
                            var matchIpAndMask = new Regex(@"ip\s+address\s(?<ip>\d+.\d+.\d+.\d+)\s+(?<mask>\d+.\d+.\d+.\d+)").Match(line);
                            var matchShutdown = new Regex(@"shutdown", RegexOptions.IgnoreCase).Match(line);

                            if (matchVRF.Success)
                            {
                                vrf = matchVRF.Groups["vrf"].Value;
                            }
                            else if (matchIpAndMask.Success)
                            {
                                ip = matchIpAndMask.Groups["ip"].Value;
                                mask = matchIpAndMask.Groups["mask"].Value;
                            }
                            else if (matchShutdown.Success)
                            {
                                shootdown = "shutdown";
                            }
                        }
                        else
                        {
                            InBlock = false;
                            dgv.Rows.Add(
                                nameStation,
                                nameInterface,
                                ip,
                                mask,
                                vrf,
                                shootdown
                                );

                            nameInterface = "";
                            ip = "";
                            mask = "";
                            vrf = "";
                            shootdown = "";
                        }
                    }
                }
            }
        }

        private static string [] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }
        private static string? GetLastFile(string dir,string pattern)=>
            Directory.GetFiles(dir, pattern).
                        Where(f => !f.Contains("SM")).
                        MaxBy(f => File.GetLastWriteTime(f));

        //private static MatchCollection ParseFromFile(string fileName,string regularExpr)
        //{
        //    using (var reader = new StreamReader(fileName))
        //    {
        //        string content = reader.ReadToEnd();
        //        var reg = new Regex(regularExpr);
        //        return reg.Matches(content);
        //    }
        //}
    }
}
