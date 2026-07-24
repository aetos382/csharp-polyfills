#if !NET5_0_OR_GREATER

using Microsoft.CodeAnalysis;

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Class,
    Inherited = false)]
[Embedded]
internal sealed class RequiresUnreferencedCodeAttribute : Attribute
{
    public RequiresUnreferencedCodeAttribute(string message)
    {
        this.Message = message;
    }

    public string Message { get; }

    public string? Url { get; init; }
}

#endif
