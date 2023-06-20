using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_Date_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2020, 09, 26);
            DateTime dataHora = new DateTime(2020, 09, 26, 14, 12, 0);

            //Podemos acessar de maneira individual o ano, mes, dia, hora, minuto e segundo individualmente. 
            Console.WriteLine("Ano: " + dataHora.Year);
            Console.WriteLine("Mês: " + dataHora.Month);
            Console.WriteLine("Dia: " + dataHora.Day);
            Console.WriteLine("Hora: " + dataHora.Hour);
            Console.WriteLine("Minutos: " + dataHora.Minute);
            Console.WriteLine("Segundos: " + dataHora.Second);
            Console.WriteLine("Dia da Semana: " + dataHora.DayOfWeek);
            Console.WriteLine("------------------------------");
            Console.WriteLine(data.ToString());
            Console.WriteLine(dataHora.ToString());

            //Pegando a Data e Hora Atual.
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine(dataHoraAtual.ToString());
            Console.WriteLine("------------------------------");

            //Conversão de String em DateTime
            DateTime dataConvertida = Convert.ToDateTime("22/11/2022");
            DateTime dataHoraConvertida = Convert.ToDateTime("22/11/2022 14:10:12");
            Console.WriteLine(dataConvertida.ToString());
            Console.WriteLine(dataHoraConvertida.ToString());
            Console.WriteLine("------------------------------");

            //Formatando a data e a hora impressa. 
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM/dd"));
            Console.WriteLine(dataHoraConvertida.ToString("HH:mm:ss"));
            Console.WriteLine("------------------------------");

            //Operações com a variável DateTime
            DateTime dataHora2 = new DateTime(2020, 09, 27, 14, 5, 20);
            dataHora2 = dataHora2.AddDays(4);
            //Para o ano: dataHora2.AddYears(2);
            //Para os meses: dataHora2.AddMonths(3);


            //Com o TimeSpan é possível Adicionar: Dias, Horas, Minutos, Segundos e Milisegundos á uma data existente.
            dataHora2 = dataHora2.Add(new TimeSpan(4, 1, 55, 00));
            Console.WriteLine(dataHora2.ToString("dd/ HH:mm:ss"));
            Console.WriteLine(dataHora2.ToString("dd/MM/yyyy"));

            //Subtraindo Datas
            DateTime dataHora3 = new DateTime(2022, 03, 01, 14, 5, 20);
            dataHora3 = dataHora3.Subtract(new TimeSpan(1, 5, 20));
            Console.WriteLine(dataHora3.ToString("HH:mm:ss"));
            
            dataHora3 = dataHora3.AddDays(-4);
            Console.WriteLine(dataHora3.ToString("dd/MM/yyyy"));


            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey();
        }
    }
}
