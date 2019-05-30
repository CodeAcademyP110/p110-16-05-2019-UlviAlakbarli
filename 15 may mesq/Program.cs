using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_may_mesq
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ulvi = new Student();
            Console.WriteLine(" ");
            Console.WriteLine("Her hansi emr daxil edin");
            Console.WriteLine("cix-Cixmaq");
            Console.WriteLine("qisa-Daxil etdiyiniz telebenin qisa melumatini gostermek");
            Console.WriteLine("tam-Daxil etdiyiniz telebenin butun melumatini gostermek");
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Istediyiniz emri daxil edin");
                string input = Console.ReadLine();
                Console.WriteLine(" ");
                if (input == "cix")
                {
                    return;
                }
                else if (input == "qisa")
                {
                    ulvi.shortinfo();
                    
                }
                else if (input == "tam")
                {
                    ulvi.fullInfo();
                    
                }
                else
                {
                    Console.WriteLine("Duzgun emr daxil edin");
                }

            }
            
        }
        
       
    }
    class Student
    {
        public string firstname;
        public string lastname;
        private string username;
        public DateTime birthday;
        public string email;
        public Student()
        {
            setF();
            setL();
            setUsername();
            SetEmail();
            setBirthday();
            

        }
        private void setF()
        {
            Console.Write("Telebe adini daxil edin  ");
            string iname = Console.ReadLine();

            int inameL = iname.Length;
            if (inameL > 2)
            {
                foreach (char a in iname)
                {
                    int xx;
                    string herf = a.ToString();
                    if (int.TryParse(herf, out xx))
                    {
                        xx = 5;
                        throw new ArgumentException("reqem daxil etme");
                    }
                }
                this.firstname = iname;

            }
            else
            {
                throw new ArgumentException("En az iki herf daxil et");
            }

        }
        private void setL()
        {
            Console.Write("Telebenin Soyadini daxil edin  ");
            string iname = Console.ReadLine();
            int inameL = iname.Length;
            if (inameL > 2)
            {
                foreach (char a in iname)
                {
                    int xx;
                    string herf = a.ToString();
                    if (int.TryParse(herf, out xx))
                    {
                        xx = 5;
                        throw new ArgumentException("reqem daxil etme");
                    }
                }
                this.lastname = iname;

            }
            else
            {
                throw new ArgumentException("En az iki herf daxil et");
            }

        }
        private void setUsername()
        {
            this.username = (firstname.ToLower() + lastname.ToLower()).Replace(" ","");
        }
        private void SetEmail()
        {
            Console.Write("Telebenin e-mail ni daxil edin(min 3 herf ve \".\" ve \"@\" xarakteri daxil olmaqla):  ");
            string iemail = Console.ReadLine();
            int emailLength = iemail.Length;
            if (emailLength < 3)
            {
                throw new ArgumentException("Email uzunlugu min 3 uzunlugda olmalidir");

            }
            int atIndex = iemail.IndexOf("@");
            int datIndex = iemail.LastIndexOf(".");
            bool atVsDat = (datIndex - atIndex)<=1;
            //Reg Exp
            if (atIndex == (-1)||datIndex==(-1)||(datIndex==(emailLength-1))||atIndex==0||(atIndex>datIndex)||atVsDat){
                throw new ArgumentException("Duzgun email daxil edin @ ve . isaresi olmalidir.");
                
            }
            if(iemail.Replace(" ", "").Length < 3)
            {
                throw new ArgumentException("Duzgun daxil et");
            }
            email = iemail.Replace(" ", "");
        }

        private void setBirthday()
        {
            Console.Write("Telebenin doguldugu tarixi gosterildiyi kimi qeyd edin: il,ay,gun ");

            string iDate = Console.ReadLine();
            string[] dateTimeArr = iDate.Split(',');
            if (dateTimeArr.Length!=3)
            {
                throw new ArgumentException("Duzgun tarix daxil edin");

            }
            int day;
            int month;
            int year;
            if (int.TryParse(dateTimeArr[0],out year))
            {
                
            }
            else
            {
                throw new ArgumentException("Duzgun tarix daxil edin");
            }
            if (int.TryParse(dateTimeArr[1], out month))
            {

            }
            else
            {
                throw new ArgumentException("Duzgun tarix daxil edin");
            }
            if (int.TryParse(dateTimeArr[2], out day))
            {

            }
            else
            {
                throw new ArgumentException("Duzgun tarix daxil edin");
            }

            DateTime birthdaY = new DateTime(year, month, day);
            if ((DateTime.Now.Year-birthday.Year) < 7)
            {
                Console.WriteLine("Yas 7-den kicik olmaz");
                return;
            }
            birthday = birthdaY;


        } 
        public void shortinfo()
        {
            Console.WriteLine("Ad: "+firstname + " Soyad: " + lastname);
        }
        public void fullInfo()
        {
            Console.WriteLine("Ad: "+firstname + " Soyad: " + lastname);
            Console.WriteLine("Email - " + email);
            Console.WriteLine("Dogum tarixi" + birthday.Day + "/" + birthday.Month + "/" + birthday.Year);
        }
        

    }


}
