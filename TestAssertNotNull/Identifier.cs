using AssertNotNull;

namespace TestAssertNotNull
{
    /// <summary>
    /// Some Test class.
    /// </summary>
    public sealed class Identifier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier"/> class.
        /// </summary>
        /// <param name="identity">The value to capture.</param>
        public Identifier(string identity)
        {
            Identity = identity;
        }

        /// <summary>
        /// Gets the captured value.
        /// </summary>
        public string Identity { get; }

        /// <summary>
        /// Checks if the value is more or less the same.
        /// </summary>
        /// <param name="test">The other value to test.</param>
        /// <returns>True or False.</returns>
        public bool IsEquivalent(Identifier test)
        {
            test.AssertNotNull(nameof(test));

            return Identity == test.Identity;
        }
    }
}
