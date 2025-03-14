class functions{
    public void add(int a, int b) {
        System.out.println(a+b);
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