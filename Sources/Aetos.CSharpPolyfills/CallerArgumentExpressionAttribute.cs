#if NETSTANDARD || !NETCOREAPP3_0_OR_GREATER

using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Parameter)]
[Embedded]
internal sealed class CallerArgumentExpressionAttribute :
    Attribute
{
    public CallerArgumentExpressionAttribute(
        string parameterName)
    {
        this.ParameterName = parameterName;
    }

    public string ParameterName { get; }
}

#endif
