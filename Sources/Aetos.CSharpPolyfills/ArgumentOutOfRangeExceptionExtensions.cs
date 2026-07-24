#if !NET8_0_OR_GREATER

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

using Microsoft.CodeAnalysis;

namespace System;

[Embedded]
internal static class ArgumentOutOfRangeExceptionExtensions
{
    extension(ArgumentOutOfRangeException)
    {
        public static void ThrowIfZero(sbyte value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(byte value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(short value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(ushort value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(int value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(uint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(long value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(ulong value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(nint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(nuint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(float value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(double value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfZero(decimal value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);

        public static void ThrowIfNegative(sbyte value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);
        public static void ThrowIfNegative(byte value, [CallerArgumentExpression(nameof(value))] string? paramName = null) { }
        public static void ThrowIfNegative(short value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);
        public static void ThrowIfNegative(ushort value, [CallerArgumentExpression(nameof(value))] string? paramName = null) { }
        public static void ThrowIfNegative(int value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);
        public static void ThrowIfNegative(uint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) { }
        public static void ThrowIfNegative(long value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);
        public static void ThrowIfNegative(ulong value, [CallerArgumentExpression(nameof(value))] string? paramName = null) { }
        public static void ThrowIfNegative(nint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);
        public static void ThrowIfNegative(nuint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) { }
        public static void ThrowIfNegative(float value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);
        public static void ThrowIfNegative(double value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);
        public static void ThrowIfNegative(decimal value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value < 0, paramName);

        public static void ThrowIfNegativeOrZero(sbyte value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);
        public static void ThrowIfNegativeOrZero(byte value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfNegativeOrZero(short value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);
        public static void ThrowIfNegativeOrZero(ushort value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfNegativeOrZero(int value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);
        public static void ThrowIfNegativeOrZero(uint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfNegativeOrZero(long value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);
        public static void ThrowIfNegativeOrZero(ulong value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfNegativeOrZero(nint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);
        public static void ThrowIfNegativeOrZero(nuint value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value == 0, paramName);
        public static void ThrowIfNegativeOrZero(float value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);
        public static void ThrowIfNegativeOrZero(double value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);
        public static void ThrowIfNegativeOrZero(decimal value, [CallerArgumentExpression(nameof(value))] string? paramName = null) => ThrowIf(value <= 0, paramName);

        public static void ThrowIfEqual<T>(
            T value,
            T other,
            [CallerArgumentExpression(nameof(value))] string? paramName = null)
        {
            ThrowIf(EqualityComparer<T>.Default.Equals(value, other), paramName);
        }

        public static void ThrowIfNotEqual<T>(
            T value,
            T other,
            [CallerArgumentExpression(nameof(value))] string? paramName = null)
        {
            ThrowIf(!EqualityComparer<T>.Default.Equals(value, other), paramName);
        }

        public static void ThrowIfGreaterThan<T>(
            T value,
            T other,
            [CallerArgumentExpression(nameof(value))] string? paramName = null)
            where T : IComparable<T>
        {
            ThrowIf(value.CompareTo(other) > 0, paramName);
        }

        public static void ThrowIfGreaterThanOrEqual<T>(
            T value,
            T other,
            [CallerArgumentExpression(nameof(value))] string? paramName = null)
            where T : IComparable<T>
        {
            ThrowIf(value.CompareTo(other) >= 0, paramName);
        }

        public static void ThrowIfLessThan<T>(
            T value,
            T other,
            [CallerArgumentExpression(nameof(value))] string? paramName = null)
            where T : IComparable<T>
        {
            ThrowIf(value.CompareTo(other) < 0, paramName);
        }

        public static void ThrowIfLessThanOrEqual<T>(
            T value,
            T other,
            [CallerArgumentExpression(nameof(value))] string? paramName = null)
            where T : IComparable<T>
        {
            ThrowIf(value.CompareTo(other) <= 0, paramName);
        }
    }

#pragma warning disable IDE0051
    private static void ThrowIf(
        [DoesNotReturnIf(true)] bool condition,
        string? paramName)
    {
        throw new ArgumentOutOfRangeException(paramName);
    }
#pragma warning restore IDE0051
}

#endif
