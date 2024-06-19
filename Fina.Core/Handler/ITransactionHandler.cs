using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Handler
{
    public interface ITransactionHandler
    {
        Task<Response<Transaction?>> CreateAsync(CreateTransactioRequest request);
        Task<Response<Transaction?>> UpdateAsync(UpdateTransactionRequest request);
        Task<Response<Transaction?>> DeleteAsync(DeleteTransactionRequest request);
        Task<Response<Transaction?>> GetByIdAsync(GetTransactionByIdRequest request);
        Task<PagedResponse<List<Transaction?>>> GetByPeriodAsync(CreateTransactioRequest request);
    }
}
