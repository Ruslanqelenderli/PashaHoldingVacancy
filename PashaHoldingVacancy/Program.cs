using PashaHoldingVacancy.Modeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PashaHoldingVacancy
{
    class Program
    {
        static void Main(string[] args)
        {
            PashaHolding pashaholding = new PashaHolding()
            {
                Id=1,
                Address="Port Baku Towers",
                CompanyName=CompanyofPashaHoldingEnum.PashaInsurance.ToString()
            };

            Candidate candidate1 = new Candidate();
           
            Vacancy vacancy = new Vacancy()
            {
                Id = 1,
                Name = VacancyEnum.InformationTechnology.ToString(),
                Requirement = "İs stajinin minimum bir il olmasi ve iş mehsuldarliliğin yüksek olmasi."

            };

            PashaInsurance pashainsurance = new PashaInsurance()
            {
                Address = "Nariman Narimanov, Sumqayit 5007",
                Id = 1,
            };


            Console.WriteLine("Pasha Holdinge xos gelmisiniz. \n");

            Console.WriteLine("Vakansiyalar:Pasha Sigorta Marketing sobesi,Maliyye shobesi,İnformasiya Texnologiyalari shobesi.\n");

            Console.WriteLine("Vakansiyanin telebleri {0}\n", vacancy.Requirement);

            candidate1.SelectVacancy(candidate1);

            Console.Write("Adiniz:");
            
            candidate1.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Soyadiniz:");

            candidate1.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Telefon nomreniz");

            candidate1.PhoneNumber = Convert.ToString(Console.ReadLine());

            Console.Write("Is stajinizi secin.Bir ilden az,Bir ile bes il arasi,Bes ilden cox:");

            candidate1.WorkExperience = Convert.ToString(Console.ReadLine());

            pashainsurance.TheFirstStageOfTheİnterview(candidate1);

            pashainsurance.TheSecondStageOfTheİnterview(candidate1);





            
       


            Console.ReadLine();

        }
    }
}
