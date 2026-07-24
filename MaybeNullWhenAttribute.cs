#if !NETSTANDARD_2_1_OR_GREATER && !NETCOREAPP_3_0_OR_GREATER

using Microsoft.CodeAnalysis;

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Parameter)]
[Embedded]
internal sealed class MaybeNullWhenAttribute : Attribute
{
    public MaybeNullWhenAttribute(
        bool returnValue)
    {
        this.ReturnValue = returnValue;
    }

    public bool ReturnValue { get; }
}

#endif
