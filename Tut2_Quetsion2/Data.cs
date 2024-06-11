using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut2_Quetsion2
{
    internal class Data
    {
        
        private int number;
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string ip;

        public int Number
        {
            get { return number; }
            set { number = value; }
                     
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
           
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
            
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
            
        }

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
            
        }



    }
}
