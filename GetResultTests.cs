using Magic8Ball;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Tests.Magic8Ball
{
    [TestFixture]
    public class GetResultTests
    {
        [Test]
        public void GetResult_ReturnNonNullNonEmptyString ()
        
        {
        //Arrange 

        //Act
        var actual = MagicBalls.GetResult(); 

        //Assert
        Assert.IsNotNull(actual);
        
        }
    }
}
