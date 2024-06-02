using task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class ManagerCall : SubscriptionRealization
    {
        public override Subscription CreateSubscription(string type, int period)
        {
            Console.WriteLine($"+1 підписка, спосіб -> дзвінок менеджеру");
            switch (type)
            {
                case "Domestic":
                    return new DomesticSubscription(period);
                case "Educational":
                    return new EducationalSubscription(period);
                case "Premium":
                    return new PremiumSubscription(period);
                default:
                    throw new Exception($"Підписки типу {type} не існує :)");
            }
        }
    }
}
