public static class Darts
{
    public static int Score(double x, double y){
        double radius = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
        if(radius <= 1) return 10 ;
        else if(radius <= 5) return 5;
        else if(radius <= 10) return 1;
        else return 0;
    }
}
