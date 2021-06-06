namespace MicroRabbit.Banking.Domain.Commands
{
    public class CreateTransferCommand : TransferCommand
    {
        public CreateTransferCommand(int to, int from, decimal amount)
        {
            To = to;
            From = from;
            Amount = amount;
        }
    }
}
