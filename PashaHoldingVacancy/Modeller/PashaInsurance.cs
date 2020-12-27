using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PashaHoldingVacancy.Modeller
{
    public class PashaInsurance

    {
        public int Id { get; set; }
        public string Address { get; set; }
        public bool OK { get; set; }

        public void TheFirstStageOfTheİnterview(Candidate candidate)
        {
            if (candidate.WorkExperience == "Bir ile bes il arasi" || candidate.WorkExperience =="Bes ilden cox" )
            {
                Console.WriteLine("Tebrik edirik siz musahibenin novbeti merhelesine kecdiniz.\n");
                OK = true;
            }
            else
            {
                Console.WriteLine("Siz interviunun növbeti merhelesine keçe bilmediniz.Size bir daha interviu üçün müraciet edilecek.\n");
                OK = false;
            };
        }

        public void TheSecondStageOfTheİnterview(Candidate candidate)
        {
            if (OK == true)
            {
                
                Console.WriteLine("Zehmet olmasa  is mehsuldarliginizi qeyd edin:Asagi,Orta,Yuksek.\n");
                candidate.Productivity = Convert.ToString(Console.ReadLine());
                if(candidate.Productivity=="Orta" || candidate.Productivity =="Yuksek" )
                {
                    Console.WriteLine("Siz ikinci musahibeni da ugurla başa vurdunuz.Tebrik edirik....\n");
                }
                else
                {
                    Console.WriteLine("Sizin musahibeniz ugursuz oldu.Size bir daha interviu üçün müraciet edilecek.\n");
                }
            }
        }

    }
}
