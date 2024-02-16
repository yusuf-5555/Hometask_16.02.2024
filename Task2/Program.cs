void func(int n)
{

    if (n == 1)
        System.Console.Write(1 + " ");
        else {
            System.Console.Write(n + " ");
            func(n - 1);
            
        
}}
int a = Convert.ToInt32(Console.ReadLine());
func(a);
