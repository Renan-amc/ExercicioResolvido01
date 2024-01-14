using System;

namespace exProposto208C.Services {
    internal class PaypalService : IOnlinePaymentsServices {
        private const double FeePercentage = 0.02;
        private const double MounthlyIntest = 0.01;

        public double Interest(double amount, int mounths) {
            return amount * MounthlyIntest * mounths;
        }

        public double PaymentFee(double amount) {
            return amount * FeePercentage;
        }
    }
}
