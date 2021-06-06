using MicroRabbit.Banking.Domain.Models;
using System.Collections.Generic;
using MicroRabbit.Banking.Application.Models;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
