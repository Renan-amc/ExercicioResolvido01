using System;

namespace exProposto208C.Services {
    interface IOnlinePaymentsServices {
        public double PaymentFee(double amount);
        public double Interest(double amount, int mounths);
    }
}
