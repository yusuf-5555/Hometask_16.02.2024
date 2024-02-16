void Nishon(int a){
    if(a<10)System.Console.Write(a);
    else{ 
        Nishon(a/10);
    System.Console.Write(" " + a%10);
    
}
}
int a = Convert.ToInt32(Console.ReadLine());
Nishon(a);
