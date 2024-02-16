
using System.Security.Cryptography;

int TestName(int value, int count = 0) 
    {
        if (value<=0)
        {
            return 0;
        }
        if (value >= 0)
        {

            value = value / 10;
            count++;
        }
        
        TestName(value,count);
        
        return count;
        
    }
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(TestName(a));