using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumptionLib
{
    public interface IConsumable
    {
        double PrixConsommationJournaliere { get; set; }
        double Consume(double prixWatt, int i);
        double PrixConsommationJournaliereVeille { get; set; }
        double ConsumeSleepMode(double prixWatt, int i);
    }
}
