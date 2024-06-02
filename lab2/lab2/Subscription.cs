namespace task1
{
    public abstract class Subscription
    {
        public abstract string Type { get; }
        public abstract string MonthlyFee { get; }
        public virtual int MinimumPeriod { get; set; }
        public abstract List<string> Channels { get; }
        public abstract List<string> Bonuses { get; }
        public abstract void SubscriptionData();
    }
}
