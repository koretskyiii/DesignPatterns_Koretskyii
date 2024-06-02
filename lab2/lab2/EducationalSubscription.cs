using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class EducationalSubscription : Subscription
    {
        public override string Type => "Premium";
        public override string MonthlyFee => "5$";
        public override int MinimumPeriod => 1;
        public override List<string> Channels => new List<string> { "W3Schools", "Epam University TV", "Освіта UA", "Udemy" };
        public override List<string> Bonuses => new List<string> { "безкоштовний доступ до онлайн-курсу з англійської мови на 3 місяці" };

        public EducationalSubscription(int period)
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
