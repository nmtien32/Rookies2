using System;
namespace Rookies2
{
public class Member
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Gender { get; set; }
        public DateTime DoB { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public uint Age
        {
            get
            {
                return (uint)(DateTime.Now.Year - DoB.Year);
            }
        }
        public bool isGraduated { get; set; }

        public override string ToString()
        {
            string Graduated = (isGraduated) ? "Graduated" : " not Graduated";
            return Firstname + "  " + Lastname + " | " + Gender + " | " + DoB.ToString("dd/MM/yyyy") + " | " + PhoneNumber + " | " + BirthPlace + " | " + Age.ToString() + " | " + Graduated;
        }
    }
}