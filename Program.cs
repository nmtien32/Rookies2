using System;

namespace Rookies2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Member> listMember = new List<Member>()
            {
                new Member(){Firstname ="Huyen", Lastname = "Nguyen", Gender = "FeMale", DoB= new DateTime(07/22/2003) , PhoneNumber = "0962838383", BirthPlace = "Ha Noi"},
                new Member(){Firstname ="Hoa", Lastname = "Nguyen", Gender = "FeMale", DoB= new DateTime(01/02/2002) , PhoneNumber = "0962838383", BirthPlace = "Ha Tay"},
                new Member(){Firstname ="Son", Lastname = "Nguyen", Gender = "Male", DoB= new DateTime(05/20/2001) , PhoneNumber = "0962838383", BirthPlace = "Ha Tinh"},
                new Member(){Firstname ="Hung", Lastname = "Nguyen", Gender = "Male", DoB= new DateTime(05/20/2002) , PhoneNumber = "0962838383", BirthPlace = "Ha Tinh"},
                new Member(){Firstname ="Hoang", Lastname = "Nguyen", Gender = "Male", DoB= new DateTime(05/20/2000) , PhoneNumber = "0962838383", BirthPlace = "Ha Noi"},
            };
            //Q1
            Console.WriteLine(" 1. Return a list of members who is Male");
            var result1 = from Member in listMember
                          where Member.Gender == "Male"
                          select Member;
            foreach (var member in result1) Console.WriteLine(member.ToString());
            //Q2
            Console.WriteLine("2. Return the oldest one based on “Age”");
            var result2 = from Member in listMember
                          orderby Member.Age descending
                          select Member;
            foreach (var member in result2)
            {
                Console.WriteLine(member.Age);
                break;
            }
            //Q3
            Console.WriteLine("3. Return a new list that contains Full Name");
            var result3 = from Member in listMember
                          select Member.Firstname + " " + Member.Lastname;
            foreach (var member in result3)
            {
                Console.WriteLine(member);
            }
            //Q4
            Console.WriteLine("4. Return 3 Lists");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Members have birth year = 2000:");
                    var result4 = from Member in listMember
                                  where Member.DoB.Year == 2000
                                  select Member;
                    foreach (var Member in result1) Console.WriteLine(Member.ToString());
                    break;
                case 2:
                    Console.WriteLine("Members have birth year > 2000:");
                    var result5 = from Member in listMember
                                  where Member.DoB.Year > 2000
                                  select Member;
                    foreach (var Member in result2) Console.WriteLine(Member.ToString());
                    break;
                case 3:
                    Console.WriteLine("Members have birth year < 2000:");
                    var result6 = from Member in listMember
                                  where Member.DoB.Year < 2000
                                  select Member;
                    foreach (var Member in result3) Console.WriteLine(Member.ToString());
                    break;
            }
            //Q5
            Console.WriteLine("5. List member who has born in Ha Noi");
            var result7 = from Member in listMember
                          where Member.BirthPlace == "Ha Noi"
                          select Member;

            foreach (var member in result7)
            {
                Console.WriteLine(member.ToString());
                break;
            }
        }
    }
}