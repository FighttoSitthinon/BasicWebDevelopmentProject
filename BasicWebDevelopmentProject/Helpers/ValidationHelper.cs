namespace BasicWebDevelopmentProject.Helpers
{
    public static class ValidationHelper
    {
        // Implement function with The Luhn algorithm to validate credit card numbers
        public static bool ValidateCreditCard(string CreditCardNumber)
        {
            int n = CreditCardNumber.Length;
            if(n!=16)return false;
            int sum = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                int tmp = CreditCardNumber[i] - '0';
                int pos = n - 1 - i;
                if (pos % 2 == 0)
                {
                    sum += tmp;
                }
                else
                {
                    tmp *= 2;
                    sum += tmp >= 10 ? (tmp % 10) + (tmp / 10) : tmp;
                }
            }
            // Console.WriteLine(sum);
            // throw new NotImplementedException();
            if (sum % 10 == 0) return true;
            else return false;
        }

        // Implement function to check sum Thai Citizen ID numbers
        public static bool ValidateCitizenId(string CitizenId)
        {
            if(CitizenId.Length!=13)return false;
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += (CitizenId[i] - '0') * (13 - i);
            }
            int remainder = 11 - (sum % 11);
            int checkDigit = remainder % 10;
            return (CitizenId[12] - '0') == checkDigit;
            // throw new NotImplementedException();
        }
    }
}

