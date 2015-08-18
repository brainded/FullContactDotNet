using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FullContactDotNet;
using System.Net;

namespace UnitTests
{
    [TestClass]
    public class FullContactPersonApiUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to instantiate without an ApiKey.")]
        public void FullContactApiInitWithNullApiKey()
        {
            var fullContactPersonApi = new FullContactPersonApi(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to instantiate with a blank ApiKey.")]
        public void FullContactApiInitWithBlankApiKey()
        {
            var fullContactPersonApi = new FullContactPersonApi("   ");
        }

        [TestMethod]
        public void FullContactInitAndLookupEmail()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByEmail("adam.dorado@gmail.com");

            Assert.AreEqual(actual.Status, HttpStatusCode.OK, "FullContactApi returned an unexpected status looking up a person by email.");
            Assert.AreEqual(actual.ContactInfo.GivenName, "Adam", "FullContactApi returned an unexpected given name looking up a person by email.");
            Assert.AreEqual(actual.ContactInfo.FamilyName, "Dorado", "FullContactApi returned an unexpected family name looking up a person by email.");
        }
    }
}
