using System;

namespace Palindrome_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        int reversedDigit(int m)
    {
        int switchingNum, addingNum = 0;
        while (m != 0)
        {
            switchingNum = m % 10;
            addingNum = addingNum * 10 + switchingNum;
            m /= 10;
        }
        return addingNum;
    }

    bool reverse(int y)
    {
        if (y == reversedDigit(y))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        int n = Convert.ToInt32(Console.ReadLine());
            if (reverse(n))
            {
                Console.WriteLine("{0} is a palindrome number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome number", n);
            }
        }
    }
}