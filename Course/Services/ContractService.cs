using Course.Entities;
using System;

namespace Course.Services
{
    class ContractService
    {
        private IOnlinePaymentService _paymentService;

        public ContractService(IOnlinePaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _paymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(fullQuota, date));
            }
        }
    }
}
