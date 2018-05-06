namespace ConsoleApp1
{
    public class SubtractOperation : IOperation
    {
        public int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}