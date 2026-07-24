# Aetos.CSharpPolyfills

A collection of polyfills that backport newer C# language features and .NET BCL APIs to older target frameworks (e.g. `netstandard2.0`, `net462`).

This is distributed as a **source-only package**. The types and extension members it provides are injected as `.cs` source directly into the consuming project's compilation, rather than shipped as a compiled assembly (most of the types are `internal`, so a normal DLL reference wouldn't be usable from the consumer anyway).

Each polyfill is guarded by a target-framework `#if` condition and is automatically excluded on frameworks where the real type/member already exists in the BCL.

## Install

```
dotnet add package Aetos.CSharpPolyfills
```

## What's included

- `System.ArgumentNullException.ThrowIfNull` (`!NET6_0_OR_GREATER`)
- `System.ArgumentOutOfRangeException.ThrowIfXxx` family (`!NET8_0_OR_GREATER`)
- `System.Runtime.CompilerServices.CallerArgumentExpressionAttribute`
- `System.Runtime.CompilerServices.CompilerFeatureRequiredAttribute`
- `System.Runtime.CompilerServices.IsExternalInit`
- `System.Runtime.CompilerServices.RequiredMemberAttribute`
- `System.Diagnostics.CodeAnalysis.DoesNotReturnAttribute`
- `System.Diagnostics.CodeAnalysis.DoesNotReturnIfAttribute`
- `System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute`
- `System.Diagnostics.CodeAnalysis.NotNullAttribute`
- `System.Diagnostics.CodeAnalysis.NotNullIfNotNullAttribute`
- `System.Diagnostics.CodeAnalysis.NotNullWhenAttribute`
- `System.Diagnostics.CodeAnalysis.RequiresDynamicCodeAttribute`
- `System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute`
- `System.Collections.Generic.KeyValuePair` deconstruction extension
- `System.String.StartsWith(char)` extension

## Supported target frameworks

`netstandard2.0`, `netstandard2.1`, `net462` (the oldest .NET Framework release still supported per the [.NET Framework lifecycle policy](https://learn.microsoft.com/lifecycle/faq/dotnet-framework)), and currently-supported .NET releases (`net8.0`, `net9.0`, `net10.0`, ...).

As a policy, this package does not keep special-case support for .NET releases once they reach end of support (per the [.NET support policy](https://dotnet.microsoft.com/platform/support/policy/dotnet-core)). When a release goes EOL, guards and overloads that existed only to preserve fidelity for that release may be simplified or dropped in a subsequent version.

## Notes

- Some polyfills (e.g. `ArgumentNullException.ThrowIfNull`) use C# extension member (`extension(...)`) blocks. Your consuming project's own `LangVersion` controls whether this syntax compiles, since the source is injected into your compilation — make sure it's high enough for your SDK (e.g. `<LangVersion>latest</LangVersion>` or `preview`, depending on your toolchain).
- The package is marked as a `development dependency`, so it won't appear as a dependency of your own published NuGet package.
- `ArgumentOutOfRangeException.ThrowIfZero`/`ThrowIfNegative`/`ThrowIfNegativeOrZero` are generic over `INumberBase<T>` in the real BCL (net8+). Since `INumberBase<T>` does not exist on the older frameworks this package targets, the polyfill instead provides non-generic overloads for the common numeric types (`sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong`, `nint`, `nuint`, `float`, `double`, `decimal`). Custom `INumberBase<T>`-implementing types are not supported on those frameworks.

## License

[MIT License](LICENSE)
