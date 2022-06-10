using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHARP_FUNDAMENTAL_1
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - DateOfBirth.Year; }
            set { Age = value; }
        }
        public bool IsGraduated { get; set; }
        //Khoi tao khong doi
        public Member()
        {
               
        }
        //Khoi tao co doi
        public Member(string FirstName
            , string LastName
            , string Gender
            , DateTime DateOfBirth
            , string PhoneNumber
            , string BirthPlace
            , bool IsGraduated)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.BirthPlace = BirthPlace;
            this.IsGraduated = IsGraduated;
        }
        public string MemberInFo()
        {
            return String.Format("{0,-15}{1,-15}{2,-15}{3,-20}{4,-15}{5,-12}{6,-10}"
                , FirstName, LastName, Gender, DateOfBirth, PhoneNumber, BirthPlace, IsGraduated);
        }
    }
}