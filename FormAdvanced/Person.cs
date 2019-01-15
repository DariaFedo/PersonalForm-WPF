using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAdvanced
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        //public combobox Country.  
        private int _Age;
        public int Age
        {
            get
            { return _Age; }

            set
            {

                if (value > 0 & value < 120)
                {
                    _Age = value;
                }
                else System.Windows.MessageBox.Show("Wrong Age!!!");

            }
        }


        private char _Sex;
        public char Sex { get { return _Sex; } set { _Sex = value; } }


        // Male information
        public string Activity { get; set; }
        public string Profession { get; set; }
        public string Gym { get; set; }

        // Female information
        public string Cosmetic { get; set; }
        public string Hobby { get; set; }
        public string Film { get; set; }


        public Person(string sName, string sSurname, string sPhone, int sAge, char sSex, string sActivity, string sProfession, string sGym, string sCosmetic,
            string sHobby, string sFilm)
        {

            this.Name = sName;
            this.Surname = sSurname;
            this.Phone = sPhone;
            this.Age = sAge;
            this.Sex = sSex;
            this.Activity = sActivity;
            this.Profession = sProfession;
            this.Gym = sGym;
            this.Cosmetic = sCosmetic;
            this.Hobby = sHobby;
            this.Film = sFilm;

        }


        public Person() { }

    }

}

