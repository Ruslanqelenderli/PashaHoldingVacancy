using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PashaHoldingVacancy.Modeller
{
    public class Vacancy : CommonModel
    {
        public string Requirement { get; set; }


        public void ShowVacancyOptions(Vacancy vacancy)
        {
            Console.WriteLine("Vakansiyanin nömresi :{0}\nVakansiyanin adi :{1}\nVakansiyanin telebleri :{2}", vacancy.Id, vacancy.Name, vacancy.Requirement);
        }
    }
}