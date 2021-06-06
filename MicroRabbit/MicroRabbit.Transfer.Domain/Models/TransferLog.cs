namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int To { get; set; }
        public int From { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
