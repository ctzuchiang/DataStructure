using System;
using DataStructure.StakeAndQueue;

namespace DataStructure.InfixToPostfix
{
    public class InfixToPostfix
    {
        public string ToPostfix(string inFix)
        {
            MyStack postFix = new MyStack(inFix.Length);
            MyStack operators = new MyStack(inFix.Length);
            char popUpOperator;
            foreach (char c in inFix.ToCharArray())
            {
                if (Char.IsLetterOrDigit(c))
                    postFix.Push(c);
                else if (c == '(')
                {
                    operators.Push(c);
                }
                else if (c == ')')
                {
                    popUpOperator = (char)operators.Pop();
                    while (popUpOperator != '(')
                    {
                        postFix.Push(popUpOperator);
                        popUpOperator = (char)operators.Pop();
                    }
                }
                else
                {
                    if (!(operators.IsEmpty()) && HigherOperatorPriority((char)operators.Peek(), c))
                    {
                        popUpOperator = (char)operators.Pop();
                        while (HigherOperatorPriority(popUpOperator, c))
                        {
                            postFix.Push(popUpOperator);

                            if (operators.IsEmpty())
                                break;

                            popUpOperator = (char)operators.Pop();
                        }
                        operators.Push(c);
                    }
                    else
                        operators.Push(c);
                }
            }
            while (operators.GetCount() > 0)
            {
                popUpOperator = (char)operators.Pop();
                postFix.Push(popUpOperator);
            }

            return postFix.ItemToString();
        }

        public int Eval(string inFix)
        {
            string postFix = ToPostfix(inFix);
            MyStack calculationStake = new MyStack(postFix.Length);
            const string operatorStr = "*/%+-";

            foreach (char c in postFix.ToCharArray())
            {
                if (Char.IsNumber(c))
                    calculationStake.Push(c.ToString());
                else
                {
                    if (!operatorStr.Contains(c.ToString())) continue;
                    int secondNum = Convert.ToInt32(calculationStake.Pop());
                    int firstNum = Convert.ToInt32(calculationStake.Pop());

                    switch (c)
                    {
                        case '+':
                        {
                            calculationStake.Push(firstNum + secondNum);
                            break;
                        }
                        case '-':
                        {
                            calculationStake.Push(firstNum - secondNum);
                            break;
                        }
                        case '*':
                        {
                            calculationStake.Push(firstNum * secondNum);
                            break;
                        }
                        case '/':
                        {
                            calculationStake.Push(firstNum / secondNum);
                            break;
                        }
                        case '%':
                        {
                            calculationStake.Push(firstNum % secondNum);
                            break;
                        }
                    }
                }
            }
            return (int)calculationStake.Pop();
        }

        private static bool HigherOperatorPriority(char firstOperator, char secondOperator)
        {
            const string operatorStr = "*/%+-";

            int[] priority = { 2, 2, 2, 3, 3 };

            var operatorOne = operatorStr.IndexOf(firstOperator);
            var operatorTwo = operatorStr.IndexOf(secondOperator);

            return (priority[operatorOne] <= priority[operatorTwo]) ? true : false;
        }
    }
}
