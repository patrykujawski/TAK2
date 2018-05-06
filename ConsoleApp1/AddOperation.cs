namespace ConsoleApp1
{
    public class AddOperation : IOperation
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}