
        #region Task 1
    static double Divide(int a, int b)
    {
        return a / b;
    }
    #endregion
    
    #region Task 2
    static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    #endregion
    
    #region Task 3
    
    static int CountOddNumbers(int n, int m)
    {
        int count = 0;
        for (int i=n; i<m; i++)
        {
            count = i % 2 == 1 ? count++ : count;
        }
        return count;
    }
    
    #endregion
    
    #region Task 4
    
    static bool IsPrime(int number)
    {
        for (int i=0; i< number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    
    #endregion
    
    
    #region Task 5
    
    static bool IsPowerOfTwo(int number)
    {
        bool isPowerOfTwo = true;
        
        while (number > 0)
        {
            if (number == 2)
            {
                break;
            }
            else if (number % 2 == 0)
            {
                number /= 2;
                continue;
            }
            isPowerOfTwo = false;
            break;
        }
        return isPowerOfTwo;
    }
    
    #endregion

