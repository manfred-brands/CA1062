using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace AssertNotNull
{
    /// <summary>
    /// Very simply code contract extensions used to validate fields within the library.
    /// </summary>
    public static class CodeContractExtensions
    {
        /// <summary>
        /// Assert that this source is not null.
        /// </summary>
        /// <typeparam name="T">The type of instance being handled.</typeparam>
        /// <param name="source">The source instance to check for null.</param>
        /// <param name="sourceName">The name of the source instance.</param>
        /// <returns>The source instance, or throws when null.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="source"/> is null.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="sourceName"/> is null.</exception>
        [DebuggerHidden]
        public static T AssertNotNull<T>([NotNull] this T? source, string sourceName)
            where T : class
        {
            if (sourceName is null)
            {
                throw new ArgumentNullException(nameof(sourceName));
            }

            if (source is null)
            {
                throw new ArgumentNullException(sourceName);
            }

            return source;
        }
    }
}
