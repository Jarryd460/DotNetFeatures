using Ardalis.SmartEnum;

namespace SmartEnums;

internal abstract class Subscriptions : SmartEnum<Subscriptions>
{
    public static readonly Subscriptions Free = new FreeTier();
    public static readonly Subscriptions Premium = new PremiumTier();
    public static readonly Subscriptions Vip = new VipTier();

    public abstract double Discount { get; }

    public Subscriptions(string name, int value) : base(name, value)
    {
    }

    private sealed class FreeTier : Subscriptions
    {
        public override double Discount => .0;

        public FreeTier() : base("Free", 1)
        {

        }
    }

    private sealed class PremiumTier : Subscriptions
    {
        public override double Discount => .25;

        public PremiumTier() : base("Premium", 2)
        {

        }
    }

    private sealed class VipTier : Subscriptions
    {
        public override double Discount => .5;

        public VipTier() : base("VIP", 3)
        {

        }
    }
}
