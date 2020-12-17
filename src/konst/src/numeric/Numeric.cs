//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    [ApiHost]
    public readonly partial struct Numeric
    {
        const NumericKind Closure = AllNumeric;

        /// <summary>
        /// Creates a parametric numeric comparer
        /// </summary>
        /// <typeparam name="T">The numeric type to compare</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ComparerProxy<T> comparer<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return (ComparerProxy<T>)(object)Compare8u();
            else if(typeof(T) == typeof(ushort))
                return (ComparerProxy<T>)(object)Compare16u();
            else if(typeof(T) == typeof(uint))
                return (ComparerProxy<T>)(object)Compare32u();
            else if(typeof(T) == typeof(ulong))
                return (ComparerProxy<T>)(object)Compare64u();
            else
                return comparer_i<T>();
        }

        [MethodImpl(Inline)]
        static ComparerProxy<T> comparer_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return (ComparerProxy<T>)(object)Compare8i();
            else if(typeof(T) == typeof(short))
                return (ComparerProxy<T>)(object)Compare16i();
            else if(typeof(T) == typeof(int))
                return (ComparerProxy<T>)(object)Compare32i();
            else if(typeof(T) == typeof(long))
                return (ComparerProxy<T>)(object)Compare64i();
            else
                return comparer_f<T>();
        }

        [MethodImpl(Inline)]
        static ComparerProxy<T> comparer_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return (ComparerProxy<T>)(object)Compare32f();
            else if(typeof(T) == typeof(double))
                return (ComparerProxy<T>)(object)Compare64f();
            else
                throw no<T>();
        }

        static IComparer<sbyte> Compare8i()
            => new ComparerProxy<sbyte>((a,b) => a.CompareTo(b));

        static IComparer<byte> Compare8u()
            => new ComparerProxy<byte>((a,b) => a.CompareTo(b));

        static IComparer<short> Compare16i()
            => new ComparerProxy<short>((a,b) => a.CompareTo(b));

        static IComparer<ushort> Compare16u()
            => new ComparerProxy<ushort>((a,b) => a.CompareTo(b));

        static IComparer<int> Compare32i()
            => new ComparerProxy<int>((a,b) => a.CompareTo(b));

        static IComparer<uint> Compare32u()
            => new ComparerProxy<uint>((a,b) => a.CompareTo(b));

        static IComparer<long> Compare64i()
            => new ComparerProxy<long>((a,b) => a.CompareTo(b));

        static IComparer<ulong> Compare64u()
            => new ComparerProxy<ulong>((a,b) => a.CompareTo(b));

        static IComparer<float> Compare32f()
            => new ComparerProxy<float>((a,b) => a.CompareTo(b));

        static IComparer<double> Compare64f()
            => new ComparerProxy<double>((a,b) => a.CompareTo(b));
    }

     partial class XTend
     {
        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="target">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this ReadOnlySpan<T> src, T target)
            where T : unmanaged
                => src.BinarySearch(target, Numeric.comparer<T>()) >= 0;
     }
}