using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FullContactDotNet;

namespace UnitTests
{
    [TestClass]
    public class FullContactLocationApiUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query location normalization with a null place.")]
        public void FullContactLocationApiGetNormalizedLocationNullPlace()
        {
            var fullContactLocationApi = new FullContactLocationApi();
            var actual = fullContactLocationApi.GetNormalizedLocation(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query location normalization with a blank place.")]
        public void FullContactLocationApiGetNormalizedLocationEmptyPlace()
        {
            var fullContactLocationApi = new FullContactLocationApi();
            var actual = fullContactLocationApi.GetNormalizedLocation(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query location enrichment with a null place.")]
        public void FullContactLocationApiGetEnrichedLocationNullPlace()
        {
            var fullContactLocationApi = new FullContactLocationApi();
            var actual = fullContactLocationApi.GetEnrichedLocation(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "FullContactApi was allowed to query location enrichment with a blank place.")]
        public void FullContactLocationApiGetEnrichedLocationEmptyPlace()
        {
            var fullContactLocationApi = new FullContactLocationApi();
            var actual = fullContactLocationApi.GetEnrichedLocation(" ");
        }
    }
}
