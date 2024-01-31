using PaySpace.Model.Models;
using PaySpace.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySpace.Service.Implementation
{
    public class CalculatorRequestService : ICalculatorRequestService
    {
        private readonly HttpClient _httpClient;
        public CalculatorRequestService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<CalculatorResponse> GetCalculatorResponse(CalculatorRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
