using System;
using System.Collections.Generic;
using System.IO;

namespace UTParse
{
    public class Parser
    {
        public static ProjectData ParseUTInfo(string utinfo) //Instance of our ProjectData class, here we will parse the input string
        {
            List<string> pre = new List<string>(); //List of parameters
            List<string> post = new List<string>(); //List of values
            string[] linesUT = utinfo.Split(Environment.NewLine); //Split our input string into multiple lines
            int currentIndex = 0; //Integer that represents the current line
            string version = "";
            foreach (string s in utinfo.Split("\n")) //Iterate through the lines of our input string
            {
                if (s.Contains("UNTONE Project Info File")) //Check if the current line is the version header
                {
                    string prefix = "UNTONE Project Info File";
                    version = s.Substring(prefix.Length + 1, 3); //Grab our version
                }
                if (s.Contains(":") && !string.IsNullOrWhiteSpace(s)) //Check if the current line is a property
                {
                    var colonIndex = s.IndexOf(":"); //Get the index (position) of the colon char in the current line
                    pre.Add(s.Substring(0, colonIndex)); //Add property name to our parameters list
                    post.Add(s.Substring(colonIndex + 2)); //Then add its value to our values list
                    if (currentIndex <= linesUT.Length) //Check if the current line index is lower than the total number of lines
                    {
                        currentIndex++; //Increment current index
                    }
                }
            }
            return new ProjectData(version, int.Parse(post[0]), post[1], post[2], post[3], post[4], post[5], post[6], post[7], post[8]); //Finally, return all of our parameters
        }
    }
}