public static class LineUp
{
    public static string Format(string name, int number) => (name , number) switch {
        (_ , int num) when number%10 == 1 && number%100 != 11 => $"{name}, you are the {number}st customer we serve today. Thank you!",
        (_ , int num) when number%10 == 2 && number%100 != 12 => $"{name}, you are the {number}nd customer we serve today. Thank you!",
        (_ , int num) when number%10 == 3 && number%100 != 13 => $"{name}, you are the {number}rd customer we serve today. Thank you!",
        (_ , _) => $"{name}, you are the {number}th customer we serve today. Thank you!",
    };
}