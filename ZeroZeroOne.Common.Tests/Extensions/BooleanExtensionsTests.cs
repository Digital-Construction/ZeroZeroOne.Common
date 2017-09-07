using NUnit.Framework;
using System;
using ZeroZeroOne.Common.Extensions;

namespace ZeroZeroOne.Common.Tests.Extensions
{
    [TestFixture]
    public class BooleanExtensionsTests
    {
        [Test]
        public void ToYesNo_Returns_Yes_If_Value_Is_True()
        {
            Assert.AreEqual("Yes", true.ToYesNo());
        }

        [Test]
		public void ToYesNo_Returns_No_If_Value_Is_False()
		{
		    Assert.AreEqual("No", false.ToYesNo());
		}
        
        [Test]
        public void ToTrueFalseText_Returns_TrueString_If_Value_Is_True()
        {
            Assert.AreEqual("Ab!1234", true.ToTrueFalseText("Ab!1234", "False"));
        }

        [Test]
        public void ToTrueFalseText_Returns_FalseString_If_Value_Is_False()
        {
            Assert.AreEqual("Yz!1234", false.ToTrueFalseText("True", "Yz!1234"));
        }
    }
}
