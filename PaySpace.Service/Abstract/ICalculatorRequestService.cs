using PaySpace.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySpace.Service.Abstract
{
    public interface ICalculatorRequestService
    {
        Task<CalculatorResponse> GetCalculatorResponse(CalculatorRequest request);
    }
}
