using Microsoft.AspNetCore.Authentication;

namespace BasicWebDevelopmentProject.Helpers
{
    public static class ValidationHelper
    {
        
        // Implement function with The Luhn algorithm to validate credit card numbers
        public static bool ValidateCreditCard(string CreditCardNumber)
        {
            int sum=0;
            for(int i = 15; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    sum+=CreditCardNumber[i]-'0';
                }
                else
                {
                    if ((CreditCardNumber[i] - '0') * 2 <= 9)
                    {
                        sum+=(CreditCardNumber[i] - '0') * 2;
                    }
                    else
                    {
                        sum+=((CreditCardNumber[i] - '0') * 2)%10;
                        sum++;
                    }
                }
            }

            if(sum%10==0)return true;
            else return false;
            // throw new NotImplementedException();
        }

        // Implement function to check sum Thai Citizen ID numbers
        
        public static bool ValidateCitizenId(string CitizenId)
        {
            
            int sum=0;
            for(int i = 0; i<=11 ; i++)
            {
                sum+=(13-i)*(CitizenId[i]-'0');
            }
            // Console.WriteLine(sum);
            if(((11-(sum%11))%10)==(CitizenId[12]-'0'))return true;
            else return false;
            // throw new NotImplementedException();
        }
    }
}
