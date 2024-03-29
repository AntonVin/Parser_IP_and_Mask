﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Parser_Ip_and_Mask
{
    internal static class DataGridViewExtensions
    {
        public static void CopyDataColumns(this DataGridView dgv,int[] indexes)
        {
            var sb = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string s = "";
                for(int i =0;i<indexes.Length;i++)
                {
                    var index = indexes[i];
                    s +=row.Cells[index].Value.ToString()+"\t";
                }
                sb.AppendLine(s[0..^1]);
            }
            var text = sb.ToString();
            if (!string.IsNullOrWhiteSpace(text))
            {
                Clipboard.Clear();
                Clipboard.SetText(text);
            }
        }
    }
}
