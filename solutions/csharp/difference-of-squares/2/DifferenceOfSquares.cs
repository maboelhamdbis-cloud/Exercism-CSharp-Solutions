public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int n)
     => (int)Math.Pow(Enumerable.Range(1, n).Sum(x => x) , 2);
        
    public static int CalculateSumOfSquares(int n)
     => Enumerable.Range(1, n).Sum(x => x * x);

    public static int CalculateDifferenceOfSquares(int n)
     => CalculateSquareOfSum(n) - CalculateSumOfSquares(n); 
}