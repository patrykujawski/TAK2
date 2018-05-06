using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Rpn
    {
        private readonly Stack<int> _stack = new Stack<int>();
        private readonly char[] _separators = { ' ', '\t' };
        private readonly IDictionary<string, IOperation> _operations = new Dictionary<string, IOperation>();

        public Rpn()
        {
            _operations.Add(new KeyValuePair<string, IOperation>("+", new AddOperation()));
            _operations.Add(new KeyValuePair<string, IOperation>("-", new SubtractOperation()));
            _operations.Add(new KeyValuePair<string, IOperation>("*", new MultiplyOperation()));
        }
        public int Calculate(string expression)
        {
            var chars = expression.Split(_separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var c in chars)
            {
                if (int.TryParse(c, out var i))
                {
                    _stack.Push(i);
                }
                else
                {
                    var pop1 = _stack.Pop();
                    var pop2 = _stack.Pop();

                    var operation = _operations[c];
                    _stack.Push(operation.Calculate(pop2, pop1));
                }
            }

           return _stack.Pop();
        }
    }
}
