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
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a null email.")]
        public void FullContactInitAndLookupNullEmail()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByEmail(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a blank email.")]
        public void FullContactInitAndLookupEmptyEmail()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByEmail(" ");
        }

        [TestMethod]
        public void FullContactInitAndLookupEmail()
        {
            //NOTE: this test will fail until an api key is put into the App.config to authenticate against
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByEmail("adam.dorado@gmail.com");

            Assert.AreEqual(HttpStatusCode.OK, actual.Status, "FullContactApi returned an unexpected status looking up a person by email.");
            Assert.AreEqual("Adam", actual.ContactInfo.GivenName, "FullContactApi returned an unexpected given name looking up a person by email.");
            Assert.AreEqual("Dorado", actual.ContactInfo.FamilyName, "FullContactApi returned an unexpected family name looking up a person by email.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a null phone.")]
        public void FullContactInitAndLookupNullPhone()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByPhone(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a blank phone.")]
        public void FullContactInitAndLookupEmptyPhone()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByPhone(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a null twitter.")]
        public void FullContactInitAndLookupNullTwitter()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByTwitter(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a blank twitter.")]
        public void FullContactInitAndLookupEmptyTwitter()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByTwitter(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a null facebook.")]
        public void FullContactInitAndLookupNullFacebook()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByFacebook(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query lookup person with a blank facebook.")]
        public void FullContactInitAndLookupEmptyFacebook()
        {
            var fullContactPersonApi = new FullContactPersonApi();
            var actual = fullContactPersonApi.LookupPersonByFacebook(" ");
        }
    }
}
