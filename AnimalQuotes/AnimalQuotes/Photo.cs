using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalQuotes
{
    class Photo
    {
        private String fileName, animal, theme;
        private String altTheme = "";

        public Photo(String fileName, String animal, String theme, String altTheme)
        {
            this.fileName = fileName;
            this.animal = animal;
            this.theme = theme;

            if (!altTheme.Equals(""))
                this.altTheme = altTheme;
        }

        public string FileName { get => fileName; set => fileName = value; }
        public string Animal { get => animal; set => animal = value; }
        public string Theme { get => theme; set => theme = value; }
        public string AltTheme { get => altTheme; set => altTheme = value; }
    }
}
