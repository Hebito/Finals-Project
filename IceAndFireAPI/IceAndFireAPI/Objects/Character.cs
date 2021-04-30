using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceAndFireAPI.Objects
{
    public class Character
    {
        //Private for setter validating
        private string name;
        private string gender;
        private string culture;
        private string born;
        private string died;
        private string url;
        
        //Getter and Setter for objects and providing N/A text
        public string Url
        {
            get { return url; }
            set
            {
                if (value == "")
                {
                    url = "N/A";
                }
                else
                {
                    url = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                {
                    name = "N/A";
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "")
                {
                    gender = "N/A";
                }
                else
                {
                    gender = value;
                }
            }
        }

        public string Culture
        {
            get { return culture; }
            set
            {
                if (value == "")
                {
                    culture = "N/A";
                }
                else
                {
                    culture = value;
                }
            }
        }

        public string Born
        {
            get { return born; }
            set
            {
                if (value == "")
                {
                    born = "N/A";
                }
                else
                {
                    born = value;
                }
            }
        }

        public string Died
            {
                get { return died; }
                set
                {
                    if (value == "")
                    {
                        died = "N/A";
                    }
                    else
                    {
                        died = value;
                    }
                }
            }
            
        public List<string> aliases { get; set; }

        public List<string> titles { get; set; }
            
        public string father { get; set; }

        public string mother { get; set; }

        public string spouse { get; set; }

        public List<string> allegiances { get; set; }

        public List<string> books { get; set; }

        public List<string> povBooks { get; set; }

        public List<string> tvSeries { get; set; }

        public List<string> playedBy { get; set; }
    }
}
