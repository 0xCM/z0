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

    using static Root;

    partial class Numeric
    {
        /// <summary>
        /// Creates a parametric numeric comparer
        /// </summary>
        /// <typeparam name="T">The numeric type to compare</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static IComparer<T> comparer<T>()
            where T : unmanaged
                => NumericCompare.create<T>();
    }

    static class NumericCompare
    {        
        readonly struct NumericComparer<T> : IComparer<T>
            where T : unmanaged
        {
            readonly Func<T,T,int> comparer;

            [MethodImpl(Inline)]
            internal NumericComparer(Func<T,T,int> comparer)
                => this.comparer = comparer;

            [MethodImpl(Inline)]
            public int Compare(T x, T y)
                => comparer(x,y);
        }

        [MethodImpl(Inline)]
        public static IComparer<T> create<T>()
            where T : unmanaged
                => comparer<T>();

        [MethodImpl(Inline)]
        static NumericComparer<T> comparer<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return (NumericComparer<T>)(object)Compare8u;
            else if(typeof(T) == typeof(ushort))
                return (NumericComparer<T>)(object)Compare16u;
            else if(typeof(T) == typeof(uint))
                return (NumericComparer<T>)(object)Compare32u;
            else if(typeof(T) == typeof(ulong))
                return (NumericComparer<T>)(object)Compare64u;
            else
                return comparer_i<T>();
        }

        [MethodImpl(Inline)]
        static NumericComparer<T> comparer_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return (NumericComparer<T>)(object)Compare8i;
            else if(typeof(T) == typeof(short))
                return (NumericComparer<T>)(object)Compare16i;
            else if(typeof(T) == typeof(int))
                return (NumericComparer<T>)(object)Compare32i;
            else if(typeof(T) == typeof(long))
                return (NumericComparer<T>)(object)Compare64i;
            else
                return comparer_f<T>();
        }

        [MethodImpl(Inline)]
        static NumericComparer<T> comparer_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return (NumericComparer<T>)(object)Compare32f;
            else if(typeof(T) == typeof(double))
                return (NumericComparer<T>)(object)Compare64f;
            else
                throw unsupported<T>();
        }

        static NumericComparer<sbyte> Compare8i 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<sbyte>((a,b) => a.CompareTo(b));
        }

        static IComparer<byte> Compare8u 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<byte>((a,b) => a.CompareTo(b));
        }

        static IComparer<short> Compare16i 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<short>((a,b) => a.CompareTo(b));
        }

        static IComparer<ushort> Compare16u 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<ushort>((a,b) => a.CompareTo(b));
        }

        static IComparer<int> Compare32i 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<int>((a,b) => a.CompareTo(b));
        }

        static IComparer<uint> Compare32u 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<uint>((a,b) => a.CompareTo(b));
        }

        static IComparer<long> Compare64i 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<long>((a,b) => a.CompareTo(b));
        }

        static IComparer<ulong> Compare64u 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<ulong>((a,b) => a.CompareTo(b));
        }

        static IComparer<float> Compare32f 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<float>((a,b) => a.CompareTo(b));
        }

        static IComparer<double> Compare64f 
        {
            [MethodImpl(Inline)]
            get => new NumericComparer<double>((a,b) => a.CompareTo(b));
        }
    }
}