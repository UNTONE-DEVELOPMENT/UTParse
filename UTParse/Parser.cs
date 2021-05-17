using System;
using System.Collections.Generic;
using System.IO;

namespace UTParse
{
    public class Parser
    {
        public static ProjectData ParseUTInfo(string utinfo)
        {
            List<string> pre = new List<string>();
            List<string> post = new List<string>();
            string[] linesUT = utinfo.Split(Environment.NewLine);
            int currentIndex = 0;
            string version = "";
            foreach (string s in utinfo.Split("\n"))
            {
                if (s.Contains("UNTONE Project Info File"))
                {
                    string prefix = "UNTONE Project Info File";
                    version = s.Substring(prefix.Length + 1, 3);
                }
                if (s.Contains(":") && !string.IsNullOrWhiteSpace(s))
                {

                    var colonIndex = s.IndexOf(":");
                    pre.Add(s.Substring(0, colonIndex));
                    post.Add(s.Substring(colonIndex + 2));
                    if (currentIndex <= linesUT.Length)
                    {
                        currentIndex++;
                    }
                }
            }
            return new ProjectData(version, int.Parse(post[0]), post[1], post[2], post[3], post[4], post[5], post[6], post[7], post[8]);
        }
    }
}