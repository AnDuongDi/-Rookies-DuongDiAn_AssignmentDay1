using System;
using System.Collections;
using System.Collections.Generic;

namespace CSHARP_FUNDAMENTAL_1
{
    class Program
    {
        public static void printTitle()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-20}{4,-15}{5,-12}{6,-10}"
                , "First Name", "Last Name", "Gender", "Date of Birth", "Phone Number", "Birth Place", "Is Graduated");
        }

        public static void Cau1(List<Member> member)
        {
            foreach (var item in member)
            {
                if(item.Gender.CompareTo("Male")==0)
                {
                    Console.WriteLine(item.MemberInFo());
                }
            }
        }

        public static void Cau2(List<Member> member)
        {
            int max = member[0].Age;
            int index=0;
            for (int i=0;i<member.Count; i++)
            {
                if (member[i].Age > max)
                {
                    max = member[i].Age;
                    index = i;
                }
            }
            Console.WriteLine(member[index].MemberInFo());
        }

        public static void Cau3(List<Member> member)
        {
            Console.WriteLine("Full Name");
            foreach (var item in member)
            {
                Console.WriteLine(item.LastName + " " + item.FirstName);
            }
        }

        public static void Cau4(List<Member> member)
        {
            int n;
            Console.WriteLine("Selections:\r\n\t1. List of members who has birth year is 2000"
                + "\r\n\t2. List of members who has birth year greater than 2000"
                + "\r\n\t3. List of members who has birth year less than 2000"
                + "\r\n\t4. Quit program");
            Console.Write("Input your selection:");
            n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    printTitle();
                    foreach (var item in member)
                    {
                        if(item.DateOfBirth.Year.CompareTo(2000)==0)
                            Console.WriteLine(item.MemberInFo());
                    }
                    break;
                case 2:
                    printTitle();
                    foreach (var item in member)
                    {
                        if (item.DateOfBirth.Year - 2000 > 0)
                            Console.WriteLine(item.MemberInFo());
                    }
                    break;
                case 3:
                    printTitle();
                    foreach (var item in member)
                    {
                        if (item.DateOfBirth.Year - 2000 < 0)
                            Console.WriteLine(item.MemberInFo());
                    }
                    break;
                case 4:
                    break;
            }
        }

        public static void Cau5(List<Member> member)
        {
            int index=0;
            while(true)
            {
                for (int i = 0; i < member.Count; i++)
                    if (member[i].BirthPlace.CompareTo("Ha Noi") == 0)
                    {
                        index = i;break;
                    }
                break;
            }
            
            Console.WriteLine(member[index].MemberInFo());
        }

        static void Main(string[] args)
        {
            //List
            List<Member> member = new List<Member>{
                new Member ("An", "Duong", "Male", DateTime.Parse("07/05/2001"), "0123456789", "Thai Nguyen", true),
                new Member ("An", "Dang", "Male", DateTime.Parse("15/06/2001"), "0123456789", "Ha Noi", false),
                new Member ("Hoa", "Nguyen", "Female", DateTime.Parse("07/07/2000"), "0123456789", "Thai Nguyen", true),
                new Member ("Ninh", "Luong", "Male", DateTime.Parse("19/09/1999"), "0123456789", "Thai Nguyen", true),
                new Member ("Linh", "Hoang", "Female", DateTime.Parse("19/05/1995"), "0123456789", "Thai Nguyen", false)
            };

            //Cau 1
            Console.WriteLine("========Cau 1!========");
            printTitle();
            Cau1(member);

            //Cau 2
            Console.WriteLine("========Cau 2!========");
            printTitle();
            Cau2(member);

            //Cau 3
            Console.WriteLine("========Cau 3!========");
            Cau3(member);

            //Cau 4
            Console.WriteLine("========Cau 4!========");
            Cau4(member);

            //Cau 5
            Console.WriteLine("========Cau 5!========");
            printTitle();
            Cau5(member);
        }
    }
}
