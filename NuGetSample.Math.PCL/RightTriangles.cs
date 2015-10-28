using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NuGetSample.Math
{

  public class RightTriangles
  {

    /// <summary>
    /// Work with pythagorean theorem to identify the hypotenuse length of a triangle
    /// </summary>
    /// <param name="a">One side's length</param>
    /// <param name="b">Second side's length</param>
    /// <returns>Third side's length</returns>
    public static double CalculateHypoteneuseLength(double a, double b)
    {

      if (a <= 0) throw new ArgumentOutOfRangeException(nameof(a), "Parameter must be greater than zero");
      if (b <= 0) throw new ArgumentOutOfRangeException(nameof(b), "Parameter must be greater than zero");
      return System.Math.Sqrt(a * a + b * b);

    }

  }

}
