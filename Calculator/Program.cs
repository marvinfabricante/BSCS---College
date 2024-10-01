// marbin fabricante -- calculator
/* It accept infix notation(X + Y) which is the common way we write expression. Then convert it into postfix(X Y +) and use push and pop to perform operation. */

using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an infix expression For EXAMPLE: (3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3):");
            string input = Console.ReadLine() ?? "Asan yung laman dol?";
            string postfix = InfixToPostfix(input);
            Console.WriteLine($"Postfix: {postfix}");
            double result = EvaluatePostfix(postfix);
            Console.WriteLine($"Result: {result}");
        }

        #region -- Precedence --
        static int GetPrecedence(char op)
        {
            // Tignan ang operator at i-return ang precedence level
            switch (op)
            {
                // Kung '+' or '-', return 1.
                case '+':
                case '-':
                    return 1;
                // Kung '*' or '/', return 2.
                case '*':
                case '/':
                    return 2;
                // Kung '^', return 3.
                case '^':
                    return 3;
                // Kung walang match, return 0.
                default:
                    return 0;
            }
        }
        #endregion

        #region -- Infix to Postfix Conversion --
        static string InfixToPostfix(string infix)
        {
            var output = new List<string>();
            var operators = new Stack<char>();
            string[] tokens = infix.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                // Kung number, idagdag sa output
                if (double.TryParse(token, out _))
                {
                    output.Add(token);
                }
                // Kung operator, tignan ang precedence
                else if (token.Length == 1 && "+-*/^".Contains(token[0]))
                {
                    // I-pop ang operators sa stack kung mas mataas o pantay ang precedence
                    while (operators.Count > 0 && GetPrecedence(operators.Peek()) >= GetPrecedence(token[0]))
                    {
                        output.Add(operators.Pop().ToString());
                    }
                    operators.Push(token[0]);
                }
                // Kung "(" ilagay sa stack
                else if (token == "(")
                {
                    operators.Push('(');
                }
                // Kung ")", i-pop ang stack hanggang mahanap ang "(".
                else if (token == ")")
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        output.Add(operators.Pop().ToString());
                    }
                    operators.Pop();
                }
            }

            // I-pop ang natitirang operators sa stack sa output.
            while (operators.Count > 0)
            {
                output.Add(operators.Pop().ToString());
            }

            return string.Join(" ", output);
        }
        #endregion

        #region -- Evaluate the Postfix --
        static double EvaluatePostfix(string postfix)
        {
            var stack = new Stack<double>();
            string[] tokens = postfix.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                // Kung ang token ay number, i-push sa stack
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    // Kung operator, i-pop ang dalawang number sa stack.
                    double right = stack.Pop();
                    double left = stack.Pop();
                    double result;

                    // Tignan ang operator and do the operation.
                    switch (token)
                    {
                        case "+":
                            result = left + right; // Addition hahshshashhsa
                            break;
                        case "-":
                            result = left - right; // Subtraction
                            break;
                        case "*":
                            result = left * right; // Multiplication
                            break;
                        case "/":
                            result = left / right; // Division
                            break;
                        case "^":
                            result = Math.Pow(left, right); // Exponentiation
                            break;
                        default:
                            throw new InvalidOperationException("Invalid operator"); // Kung walang input
                    }

                    // I-push yung result pabalik sa stack
                    stack.Push(result);
                }
            }

            // I-pop at ibalik yung final result sa stack.
            return stack.Pop();
        }
        #endregion

    }
}
