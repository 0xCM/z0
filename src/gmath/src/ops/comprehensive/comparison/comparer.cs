//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial class gmath
    {
        /// <summary>
        /// Creates a parametric numeric comparer
        /// </summary>
        /// <typeparam name="T">The numeric type to compare</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ComparerProxy<T> comparer<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return (ComparerProxy<T>)(object)Compare8u;
            else if(typeof(T) == typeof(ushort))
                return (ComparerProxy<T>)(object)Compare16u;
            else if(typeof(T) == typeof(uint))
                return (ComparerProxy<T>)(object)Compare32u;
            else if(typeof(T) == typeof(ulong))
                return (ComparerProxy<T>)(object)Compare64u;
            else
                return comparer_i<T>();
        }

        [MethodImpl(Inline)]
        static ComparerProxy<T> comparer_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return (ComparerProxy<T>)(object)Compare8i;
            else if(typeof(T) == typeof(short))
                return (ComparerProxy<T>)(object)Compare16i;
            else if(typeof(T) == typeof(int))
                return (ComparerProxy<T>)(object)Compare32i;
            else if(typeof(T) == typeof(long))
                return (ComparerProxy<T>)(object)Compare64i;
            else
                return comparer_f<T>();
        }

        [MethodImpl(Inline)]
        static ComparerProxy<T> comparer_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return (ComparerProxy<T>)(object)Compare32f;
            else if(typeof(T) == typeof(double))
                return (ComparerProxy<T>)(object)Compare64f;
            else
                throw Unsupported.define<T>();
        }

        static ComparerProxy<sbyte> Compare8i 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<sbyte>((a,b) => a.CompareTo(b));
        }

        static IComparer<byte> Compare8u 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<byte>((a,b) => a.CompareTo(b));
        }

        static IComparer<short> Compare16i 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<short>((a,b) => a.CompareTo(b));
        }

        static IComparer<ushort> Compare16u 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<ushort>((a,b) => a.CompareTo(b));
        }

        static IComparer<int> Compare32i 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<int>((a,b) => a.CompareTo(b));
        }

        static IComparer<uint> Compare32u 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<uint>((a,b) => a.CompareTo(b));
        }

        static IComparer<long> Compare64i 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<long>((a,b) => a.CompareTo(b));
        }

        static IComparer<ulong> Compare64u 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<ulong>((a,b) => a.CompareTo(b));
        }

        static IComparer<float> Compare32f 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<float>((a,b) => a.CompareTo(b));
        }

        static IComparer<double> Compare64f 
        {
            [MethodImpl(Inline)]
            get => new ComparerProxy<double>((a,b) => a.CompareTo(b));
        }
     }
}