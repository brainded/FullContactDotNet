using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FullContactDotNet;

namespace UnitTests
{
    [TestClass]
    public class FullContactApiUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to instantiate without an ApiKey.")]
        public void FullContactApiInitWithNullApiKey()
        {
            var fullContactApi = new FullContactApi(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to instantiate with a blank ApiKey.")]
        public void FullContactApiInitWithBlankApiKey()
        {
            var fullContactApi = new FullContactApi("   ");
        }
    }
}
