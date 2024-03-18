using TechExam2.Interface;

namespace TechExam2.Service
{
    public class CalculatorService : ICalculatorService
    {
        //need to remove task because this method return an int and completely synchronous. The async await method is now define in the controller.
        public int RoundingSumOf2Int(int firstNumber, int secondNumber)
        {
            int roundedValue = 0;
            int sum = 0;
            //declare a var used for the multiple of 5
            int nextMultiplier = 0;

            //no need to initialize another parameter because var sum is already defined above
            sum = firstNumber + secondNumber;
            //get the next multiple of 5 by just dividing the numbers to 5 to get the whole number quotient, then multiple it by 5 and adding by 5.
            nextMultiplier = ((sum / 5) * 5) + 5;
            //applying the condition if the difference between the nextmultiplier and the sum is less than 3 then get the value of the nextmultiplier, else simply get the sum of the first and 2nd number.
            roundedValue = (nextMultiplier - sum) < 3 ? nextMultiplier : sum;

            return roundedValue;
        }
    }
}
