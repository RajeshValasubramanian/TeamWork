class functions{

    public void mul(int a,int b){
        int pro=a*b;
        system.WriteLine("The product is:"+pro);
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