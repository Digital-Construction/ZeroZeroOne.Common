using NUnit.Framework;
using System;
using ZeroZeroOne.Common.Extensions;

namespace ZeroZeroOne.Common.Tests.Extensions
{
    [TestFixture()]
    public class StringExtensionsTests
    {
        [Test()]
        public void HasValue_Returns_True_If_String_Is_Not_Empty()
        {
            var theValue = "This is a string";

            var hasValue = theValue.HasValue();

            Assert.IsTrue(hasValue);
        }

		[Test()]
		public void HasValue_Returns_False_If_String_Is_Empty()
		{
			var theValue = "";

			var hasValue = theValue.HasValue();

			Assert.IsFalse(hasValue);
		}

		[Test()]
		public void HasValue_Returns_False_If_String_Is_Null()
		{
			String theValue = null;

			var hasValue = theValue.HasValue();

			Assert.IsFalse(hasValue);
		}
    }
}
