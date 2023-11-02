using System.Text;

namespace Assignment4
{
    public class NumericFunctions
    {
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1,int num2)
        {
            return (num1 - num2);
        }
        public static int Multiply(int num1,int num2)
        {
            return num1 * num2;
        }
        public static float Divide(float num1,float num2)
        { 
            return num1 / num2;
        }
        public static int FindMax(int num1,int num2)
        {
            return num1>num2?num1 : num2;
        }
        public static int FindMin(int num1,int num2)
        {
            return num1 > num2 ? num2 : num1;
        }
        public static bool CheckOdd(int num)
        {
            return num%2==0?false:true;
        }
        public static bool CheckEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public static bool IsPrime(int num)
        {
            for(int i = 2; i < Math.Sqrt(num); i++)
            {
                if(num%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}