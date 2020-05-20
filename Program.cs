using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int ano;
            
            Console.Write("Digite o dia que voce nasceu: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o mes que voce nasceu: ");
            mes = Convert.ToInt32(Console.ReadLine());

            string[] listmes = new string[12];
            listmes[0] = "Janeiro";
            listmes[1] = "Fevereiro";
            listmes[2] = "Marco";
            listmes[3] = "Abril";
            listmes[4] = "Maio";
            listmes[5] = "Junho";
            listmes[6] = "Julho";
            listmes[7] = "Agosto";
            listmes[8] = "Setembro";
            listmes[9] = "Outubro";
            listmes[10] = "Novembro";
            listmes[11] = "Dezembro";

            

            Console.Write("Digite o ano que voce nasceu: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.Write("Voce nasceu em " + dia + " de " + listmes[mes - 1] + " de " + ano);

            Console.ReadLine();        


        }
    }
}
