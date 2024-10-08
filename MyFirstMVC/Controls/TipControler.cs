using MyFirstMVC.Models;
using MyFirstMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Controls
{
    public class TipControler
    {
        Display myDisp = new Display();
        Tip myTip = new Tip();
        public TipControler()
        {
            myDisp.Input();

            myTip.Amount = myDisp.Amount;
            myTip.Percent=myDisp.Persent;

            myDisp.TipSum = myTip.CalculateTip();
            myDisp.TotalSum = myTip.CalculateTotal();

            myDisp.Output();

        }
    }
}
