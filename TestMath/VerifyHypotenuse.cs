using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestMath
{

  public class VerifyHypotenuse
  {

    [Fact]
    public void ShouldCalculateNormally()
    {

      // Arrange
      var arg1 = 3D;
      var arg2 = 4D;

      // Act
      var result = NuGetSample.Math.RightTriangles.CalculateHypoteneuseLength(arg1, arg2);

      // Assert
      Assert.Equal(5, result);

    }

    [Fact]
    public void ShouldErrorOnNonPositiveArguments()
    {

      // Arrange
      var arg1 = -1D;
      var arg2 = 4D;

      // Act , Assert
      Assert.Throws<ArgumentOutOfRangeException>("a", () => {
        NuGetSample.Math.RightTriangles.CalculateHypoteneuseLength(arg1, arg2);
      });
        
    }

  }

}
