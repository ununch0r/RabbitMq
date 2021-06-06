using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Transfer.Domain.Events
{
    public class TransferCreatedEvent : Event
    {
        public int To { get; }
        public int From { get; }
        public decimal Amount { get; }

        public TransferCreatedEvent(int to, int from, decimal amount)
        {
            To = to;
            From = from;
            Amount = amount;
        }
    }
}
