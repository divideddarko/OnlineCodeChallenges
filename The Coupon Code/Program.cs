using System;

// Story
// Your online store likes to give out coupons for special occasions. Some customers try to cheat the system by entering invalid codes or using expired coupons.

// Task
// Your mission:
// Write a function called which verifies that a coupon code is valid, the coupon is not expired.

// A coupon is no more valid on the day AFTER the expiration date. All dates will be passed as strings in this format: "MONTH DATE, YEAR".

// Examples:
// CheckCoupon("123", "123", "July 9, 2015", "July 9, 2015")  ==  true
// CheckCoupon("123", "123", "July 9, 2015", "July 2, 2015")  ==  false


namespace The_Coupon_Code
{
     class Program
     {
          static void Main(string[] args)
          {
               Console.WriteLine(CheckCoupon("123", "123", "July 9, 2015", "July 9, 2015"));
          }

          public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
          {
               bool result = false;
               DateTime cD = Convert.ToDateTime(currentDate);
               DateTime eD = Convert.ToDateTime(expirationDate);

               if (enteredCode == correctCode)
               {
                    if (eD >= cD)
                    {
                         result = true;
                    }
               }

               return result;
          }
     }
}
