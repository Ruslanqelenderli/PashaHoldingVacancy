using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PashaHoldingVacancy.Modeller
{
    public class Candidate:CommonModel
    {
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkExperience { get; set; }
        public string Productivity { get; set; }
        public string AppliedVacancy { get; set; }


        public void SelectVacancy(Candidate candidate)
        {
            Console.Write("Zehmet olmasa bas vurdugunuz vakansiyani yazin:");
            candidate.AppliedVacancy = Convert.ToString(Console.ReadLine());

        }
    }
}
