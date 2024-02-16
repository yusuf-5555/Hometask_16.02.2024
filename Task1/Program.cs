void func(int n)
{

    if (n == 1)
        System.Console.Write(1);
        else {
            func(n - 1);
            System.Console.Write(" "+n);
        
}}
int a = Convert.ToInt32(Console.ReadLine());
func(a);