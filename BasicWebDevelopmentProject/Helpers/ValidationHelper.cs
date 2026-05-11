namespace BasicWebDevelopmentProject.Helpers
{
    public static class ValidationHelper
    {
        // Implement function with The Luhn algorithm to validate credit card numbers
        public static bool ValidateCreditCard(string CreditCardNumber)
        {
            if (CreditCardNumber.Length != 16)
            {
                return false;
            }

            int sum = 0;
            for (int i = CreditCardNumber.Length - 1; i >= 0; --i)
            {
                int d = CreditCardNumber[i] - '0';
                if (i % 2 == 0)
                {
                    d *= 2;
                    if (d > 9)
                    {
                        string ds = d.ToString();
                        d = ds[0] + ds[1] - 2 * '0';
                    }
                }
                sum += d;
            }

            if (sum % 10 == 0)
            {
                return true;
            }

            return false;
        }

        // Implement function to check sum Thai Citizen ID numbers
        public static bool ValidateCitizenId(string CitizenId)
        {
            if (CitizenId.Length != 13)
            {
                return false;
            }
            
            int sum = 0;
            for (int i = 0; i < CitizenId.Length - 1; ++i)
            {
                sum += (13 - i) * (CitizenId[i] - '0');
            }

            int remainder = sum % 11;
            string str_check_digit = (11 - remainder).ToString();
            char check_digit = str_check_digit[str_check_digit.Length - 1];

            return check_digit == CitizenId[CitizenId.Length - 1];
        }
    }
}
