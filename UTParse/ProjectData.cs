using System;
namespace UTParse
{
    public class ProjectData //Set up a class to store our parsed data
    {
        public string Version { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }
        public string Genre { get; set; }
        public string Framework { get; set; }
        public string Language { get; set; }
        public string Location { get; set; }
        public string Creator { get; set; }
        public string Copyright { get; set; }

        public ProjectData(string ver, int id, string nm, string ed, string gnr, string frm, string lang, string loc, string cr, string cc) //Class constructor taking in 10 args
        {
            this.Version = ver;
            this.ID = id;
            this.Name = nm;
            this.Edition = ed;
            this.Genre = gnr;
            this.Framework = frm;
            this.Language = lang;
            this.Location = loc;
            this.Creator = cr;
            this.Copyright = cc;
        }

    }
}
