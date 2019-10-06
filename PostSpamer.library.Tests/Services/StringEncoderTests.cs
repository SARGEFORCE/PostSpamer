using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSpamer.library.Services;

namespace PostSpamer.library.Tests.Services
{
    [TestClass]
    public class StringEncoderTests
    {
        [TestMethod]
        public void Encode_ABC_to_BCD_with_key_1()
        {   //Прицнип AAA
            //Arrange
            //Act
            //Assert

            #region Assert
            var str = "ABC";
            var expected_result = "BCD";
            var key = 1;
            #endregion

            #region Act
            var actual_result = StringEncoder.Encode(str, key);
            #endregion

            #region Assert
            Assert.AreEqual(expected_result, actual_result);
            #endregion

        }
        [TestMethod]
        public void Decode_BCD_to_ABC_with_key_1()
        {   
            #region Assert
            var str = "BCD";
            var expected_result = "ABC";
            var key = 1;
            #endregion

            #region Act
            var actual_result = StringEncoder.Decode(str, key);
            #endregion

            #region Assert
            Assert.AreEqual(expected_result, actual_result);
            #endregion

        }
    }
}
