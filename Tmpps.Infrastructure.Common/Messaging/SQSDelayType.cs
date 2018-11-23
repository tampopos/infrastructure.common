namespace Tmpps.Infrastructure.Common.Messaging
{
    public enum SQSDelayType
    {
        Constant,
        LinerIncrease,
        ExponentialIncrease,
    }
}