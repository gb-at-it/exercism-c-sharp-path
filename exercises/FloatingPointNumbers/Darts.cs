using System;

namespace Dart;

public static class Darts
{
    public static int Score(double x, double y)
        => (x * x + y * y) switch
        {
            > 100 => 0,
            > 25 => 1,
            > 1 => 5,
            _ => 10
        };
}
    
