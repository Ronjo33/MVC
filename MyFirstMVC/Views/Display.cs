using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {
        public double Amount { get; set; }
        public double Persent { get; set; }
        public double TipSum{ get; set; }
        public double TotalSum { get; set; }
        public void Input() 
        {
            Console.Write("Въведете сумата на сметката: ");
            double sum = double.Parse(Console.ReadLine());
            this.Amount = sum;

            Console.Write("Въведете процента на келнера: ");
            double percent = double.Parse(Console.ReadLine());
            this.Persent = percent;



        }
        public void Output() 
        {
            Console.WriteLine($"Бакшиш за сервитьора:{this.TotalSum}лв");
            Console.WriteLine($"Сумата за плащане: {this.TotalSum}лв");
        }

    }
}
