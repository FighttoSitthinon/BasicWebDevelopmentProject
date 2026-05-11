namespace BasicWebDevelopmentProject.Helpers
{
    public static class ValidationHelper
    {
        // Implement function with The Luhn algorithm to validate credit card numbers
        public static bool ValidateCreditCard(string CreditCardNumber)
        {
            int n = CreditCardNumber.Length;
            int sum = 0;
            for(int i = n - 1; i >= 0; i--)
            {
                int tmp = CreditCardNumber[i]-'0';
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
            if(sum%10==0)return true;
            else return false;
        }

        // Implement function to check sum Thai Citizen ID numbers
        public static bool ValidateCitizenId(string CitizenId)
        {
            int sum=0;
            int n=CitizenId.Length;
            for(int i = 0; i < n-1; i++)
            {
                sum+=(CitizenId[i]-'0')*(13-i);
            }
            sum = sum%11;
            int remiander = 11 - sum;
            if(remainder/10 >= 1)
            {
                remiander = remainder
            }
            if(CitizenId[12]-'0' == )
            // throw new NotImplementedException();
        }
    }
}
