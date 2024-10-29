using System.Data;

namespace SkillCheck.Logic;
public class Calculator
{
    public int Calculate(string equation)
    {
        if (string.IsNullOrEmpty(equation)) return 0;

        Stack<int> numbers = new Stack<int>();
        Stack<char> operators = new Stack<char>();

        for (int i = 0; i < equation.Length; i++)
        {
            if (char.IsDigit(equation[i]))
            {
                int number = 0;
                while (i < equation.Length && char.IsDigit(equation[i]))
                {
                    number = number * 10 + (equation[i] - '0');
                    i++;
                }
                i--;
                numbers.Push(number);
            }
            else if (equation[i] == '(')
            {
                operators.Push(equation[i]);
            }
            else if (equation[i] == ')')
            {
                while (operators.Count > 0 && operators.Peek() != '(')
                {
                    numbers.Push(ApplyOperation(operators.Pop(), numbers.Pop(), numbers.Pop()));
                }
                operators.Pop();
            }
            else if (IsOperator(equation[i]))
            {
                while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(equation[i]))
                {
                    numbers.Push(ApplyOperation(operators.Pop(), numbers.Pop(), numbers.Pop()));
                }
                operators.Push(equation[i]);
            }
        }

        while (operators.Count > 0)
        {
            numbers.Push(ApplyOperation(operators.Pop(), numbers.Pop(), numbers.Pop()));
        }

        return numbers.Pop();
    }

    private bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    private int Precedence(char op)
    {
        if (op == '+' || op == '-')
            return 1;
        if (op == '*' || op == '/')
            return 2;
        return 0;
    }

    private int ApplyOperation(char op, int b, int a)
    {
        switch (op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/':
                if (b == 0) throw new DivideByZeroException();
                return a / b;
        }
        return 0;
    }
}



