using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Operations.Leet_Code.Stack
{
    // 150. Evaluate Reverse Polish Notation
    // https://leetcode.com/problems/evaluate-reverse-polish-notation/
    // Difficulty: Medium | Topic: Stack
    // Time: O(n) | Space: O(n)

    // Approach:
    // Iterate over the array pushing every number onto the stack.
    // When we hit an operator, pop the last 2 elements, apply the operation,
    // and push the result back. The final answer is the last element in the stack.

    public class EvaluateRPN
    {
        public int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == "+")
                    stack.Push(stack.Pop() + stack.Pop());
                else if (tokens[i] == "-")
                    stack.Push(-stack.Pop() + stack.Pop());
                else if (tokens[i] == "*")
                    stack.Push(stack.Pop() * stack.Pop());
                else if (tokens[i] == "/")
                {
                    int denominator = stack.Pop();
                    stack.Push(stack.Pop() / denominator);
                }
                else
                    stack.Push(int.Parse(tokens[i]));
            }
            return stack.Pop();
        }
    }


    //Initial Solution (No Refactor):

    //public int EvalRPN(string[] tokens)
    //{
    //    Stack<string> stack = new Stack<string>();
    //    int output = 0, a = 0, b = 0;

    //    for (int i = 0; i < tokens.Length; i++)
    //    {
    //        if (tokens[i] == "+")
    //        {
    //            Int32.TryParse(stack.Pop(), out a);
    //            Int32.TryParse(stack.Pop(), out b);
    //            output = a + b;
    //            stack.Push(output.ToString());
    //        }
    //        else if (tokens[i] == "-")
    //        {
    //            Int32.TryParse(stack.Pop(), out a);
    //            Int32.TryParse(stack.Pop(), out b);
    //            output = b - a;
    //            stack.Push(output.ToString());
    //        }
    //        else if (tokens[i] == "*")
    //        {
    //            Int32.TryParse(stack.Pop(), out a);
    //            Int32.TryParse(stack.Pop(), out b);
    //            output = a * b;
    //            stack.Push(output.ToString());
    //        }
    //        else if (tokens[i] == "/")
    //        {
    //            Int32.TryParse(stack.Pop(), out a);
    //            Int32.TryParse(stack.Pop(), out b);
    //            output = b / a;
    //            stack.Push(output.ToString());
    //        }
    //        else
    //            stack.Push(tokens[i]);
    //    }
    //    Int32.TryParse(stack.Pop(), out int result);
    //    return result;
    //}
}
