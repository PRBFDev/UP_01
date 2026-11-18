using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_UP01 {

    public class Wallet {
        public string Country { get; set; }
        private double balance;
       public double Balance {
            get => balance;
            set
            {
                if (balance == value) return;
                double old = balance;
                balance = value;
                Changed?.Invoke(old,balance);
            }
        }
        public bool Deposit(double amount) {
            if (amount > 0f) {
                Balance += amount;
                return true;
            }
         return false;
        }
        public bool Widthraw(double amount) {
            if (Balance >= amount && amount > 0) {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public event Action<double, double> Changed;
    }

    public class VerificationVariable<T> {
        public T Value { get; set; }
        public bool Verified { get; set; }

        public VerificationVariable(T newValue = default, bool verified = false) {
            Value = newValue;
            Verified = verified;
        }

        public static implicit operator T(VerificationVariable<T> v) => v.Value;
        public static implicit operator VerificationVariable<T>(T newVal) => new VerificationVariable<T>(newVal);

        public static bool operator true(VerificationVariable<T> v) => v.Verified;
        public static bool operator false(VerificationVariable<T> v) => !v.Verified;
    }



    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public VerificationVariable<string> Email { get; set; }
        public VerificationVariable<string> PhoneNumber { get; set; }

        public Wallet Wallet { get; private set; }


    }
}
