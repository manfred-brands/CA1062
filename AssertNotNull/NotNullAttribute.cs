#if NETSTANDARD2_0

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>Specifies that an output will not be null even if the corresponding type allows it.</summary>
    [ExcludeFromCodeCoverage]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.ReturnValue, Inherited = false)]
    internal sealed class NotNullAttribute : Attribute
    {
    }
}

#endif

