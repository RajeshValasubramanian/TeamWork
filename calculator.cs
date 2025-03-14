class functions{

    public int div(int a,int b)
    {
        if(b==0)
        {
            Console.Writeline("Denominator cannot be zero");
            return 0;
        }

        Console.Writeline("Division of two numbers "+a/b);

    }
    
}
class Tasks{
    public static void Main(string[] args){
        functions obj=new functions();
        int a=10,b=10;
        obj.add(a,b);//Balaji
        obj.sub(a,b);//Aashik
        obj.mul(a,b);//Bangaru
        obj.div(a,b);//Sandhiya
    }
}