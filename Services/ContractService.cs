using exProposto208C.Entities;

namespace exProposto208C.Services {
    internal class ContractService {

        private IOnlinePaymentsServices _onlinePaymentsServices;

        public ContractService(IOnlinePaymentsServices onlinePaymentsServices) {
            _onlinePaymentsServices = onlinePaymentsServices;
        }

        public void ProcessContract(Contract contract, int mounths) {
            double basicQuota = contract.TotalValue / mounths;
            for (int i = 1; i <= mounths; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = basicQuota + _onlinePaymentsServices.Interest(basicQuota, i);
                double fullQuota = updateQuota + _onlinePaymentsServices.PaymentFee(updateQuota);
                contract.addInstallments(new Installments(date, fullQuota));
            }
        }
    }
}
