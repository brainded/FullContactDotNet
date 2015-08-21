using FullContactDotNet.Name;

namespace FullContactDotNet
{
    public interface IFullContactNameApi
    {
        /// <summary>
        /// Gets the name normalization.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameResponse GetNameNormalization(string name, Casing? casing = null);

        /// <summary>
        /// Gets the name deduction by email.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameResponse GetNameDeductionByEmail(string emailAddress, Casing? casing = null);

        /// <summary>
        /// Gets the name deduction by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameResponse GetNameDeductionByUsername(string username, Casing? casing = null);

        /// <summary>
        /// Gets the name similarity.
        /// </summary>
        /// <param name="nameA">The name a.</param>
        /// <param name="nameB">The name b.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameSimilarityResponse GetNameSimilarity(string nameA, string nameB, Casing? casing = null);

        /// <summary>
        /// Gets the stats of a name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameStatsResponse GetNameStatsByName(string name, Casing? casing = null);

        /// <summary>
        /// Gets the stats of a given and family name.
        /// </summary>
        /// <param name="givenName">The given name.</param>
        /// <param name="familyName">The family name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameStatsResponse GetNameStatsByName(string givenName, string familyName, Casing? casing = null);

        /// <summary>
        /// Gets the stats of a given name.
        /// </summary>
        /// <param name="givenName">The given name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameStatsResponse GetNameStatsByGivenName(string givenName, Casing? casing = null);

        /// <summary>
        /// Gets the stats of a family name.
        /// </summary>
        /// <param name="familyName">The family name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameStatsResponse GetNameStatsByFamilyName(string familyName, Casing? casing = null);

        /// <summary>
        /// Gets the parsed name for a given ambiguous name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="casing">The casing.</param>
        /// <returns></returns>
        NameParsedResponse GetNameParsed(string name, Casing? casing = null);
    }
}
