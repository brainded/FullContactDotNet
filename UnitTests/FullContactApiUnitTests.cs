using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FullContactDotNet;
using System.Net;

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

        [TestMethod]
        public void FullContactInitAndLookupEmail()
        {
            var fullContactApi = new FullContactApi();
            var actual = fullContactApi.LookupPersonByEmail("adam.dorado@gmail.com");

            Assert.AreEqual(actual.Status, HttpStatusCode.OK, "FullContactApi returned an unexpected status looking up a person by email.");
            Assert.AreEqual(actual.ContactInfo.GivenName, "Adam", "FullContactApi returned an unexpected given name looking up a person by email.");
            Assert.AreEqual(actual.ContactInfo.FamilyName, "Dorado", "FullContactApi returned an unexpected family name looking up a person by email.");
        }
    }
}
