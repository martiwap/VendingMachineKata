using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineKata.Models;

namespace VendingMachineKata.Services
{
    public class ValidateInputService : IValidateInputService
    {
        // 1p, 2p, 5p, 10p, 20p, 50p, £1, £2
        public Dictionary<string, double> ValidCoins = new Dictionary<string, double>
        {
              {"1p",0.01},
              {"2p",0.02},
              {"5p",0.05},
              {"10p",0.10},
              {"20p",0.20},
              {"50p",0.50},
              {"£1",1},
              {"£2",2},
        };

        public double ConvertInputToValue(object input)
        {
            double amountEntered = 0;

            if (!IsInputValid(input))
                return amountEntered;

            foreach (var coin in ValidCoins)
            {
                if (input.ToString() == coin.Key)
                    amountEntered = coin.Value;

                var amount = this.GetNum(input);
                if (amount == coin.Value)
                    amountEntered = coin.Value;
            }

            return amountEntered;
        }

        private double GetNum(object input)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(input), out retNum) && !Double.IsNaN(retNum);

            if (!isNum)
                return 0;

            return retNum;
        }

        public bool IsInputValid(object input)
        {
            if (input.ToString().Contains("£") || input.ToString().Contains("p"))
            {
                foreach (var coin in ValidCoins)
                {
                    if (input == coin.Key)
                        return true;
                }
            }

            var inputAmount = this.GetNum(input);

            if (inputAmount == 0)
                return false;

            foreach (var coin in ValidCoins)
            {
                if (inputAmount == coin.Value)
                    return true;
            }

            return false;
        }

        public bool IsMoneyInsertedEnough(double input, double required)
        {
            if (input < required)
                return false;

            return true;
        }
    }

    public interface IValidateInputService
    {
        bool IsInputValid(object input);

        double ConvertInputToValue(object input);

        bool IsMoneyInsertedEnough(double input, double required);
    }
}
