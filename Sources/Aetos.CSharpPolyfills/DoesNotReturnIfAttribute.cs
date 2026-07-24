#if !NETSTANDARD2_1_OR_GREATER && !NETCOREAPP3_0_OR_GREATER

using Microsoft.CodeAnalysis;

namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Parameter)]
[Embedded]
internal sealed class DoesNotReturnIfAttribute :
    Attribute
{
    public DoesNotReturnIfAttribute(
        bool parameterValue)
    {
        this.ParameterValue = parameterValue;
    }

    public bool ParameterValue { get; }
}

#endif
