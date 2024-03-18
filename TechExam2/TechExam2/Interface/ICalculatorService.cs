namespace TechExam2.Interface
{
    public interface ICalculatorService
    {
        //need to remove task because this method return an int and completely synchronous. The async await method is now define in the controller.
        int RoundingSumOf2Int(int firstNumber, int secondNumber);
    }
}
