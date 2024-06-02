using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class DomesticSubscription : Subscription
    {
        public override string Type => "Premium";
        public override string MonthlyFee => "10$";
        public override int MinimumPeriod => 1;
        public override List<string> Channels => new List<string> { "Лачен пише...", "Megogo Футбол", "Setanta Sports", "Музмарафон", "Канал для діток:)" };
        public override List<string> Bonuses => new List<string> { "В найближчиих акціях дана підписка участі не бере." } ;

        public DomesticSubscription(int period)
        {
            MinimumPeriod = period;
        }
        public override void SubscriptionData()
        {
            Console.WriteLine($"Ціна підписки {this.Type} -> {this.MonthlyFee}," +
                                 $" мінімальний період -> {this.MinimumPeriod}," +
                                 $" доступні канали: '{string.Join("', '", Channels)}\n" +
                                 $" бонуси підписки: {string.Join(", ", Bonuses)}\n\n");
        }
    }
}
