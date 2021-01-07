//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Numeric
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

        static ComparerProxy<sbyte> Compare8i()
            => new ComparerProxy<sbyte>((a,b) => a.CompareTo(b));

        static ComparerProxy<byte> Compare8u()
            => new ComparerProxy<byte>((a,b) => a.CompareTo(b));

        static ComparerProxy<short> Compare16i()
            => new ComparerProxy<short>((a,b) => a.CompareTo(b));

        static ComparerProxy<ushort> Compare16u()
            => new ComparerProxy<ushort>((a,b) => a.CompareTo(b));

        static ComparerProxy<int> Compare32i()
            => new ComparerProxy<int>((a,b) => a.CompareTo(b));

        static ComparerProxy<uint> Compare32u()
            => new ComparerProxy<uint>((a,b) => a.CompareTo(b));

        static ComparerProxy<long> Compare64i()
            => new ComparerProxy<long>((a,b) => a.CompareTo(b));

        static ComparerProxy<ulong> Compare64u()
            => new ComparerProxy<ulong>((a,b) => a.CompareTo(b));

        static ComparerProxy<float> Compare32f()
            => new ComparerProxy<float>((a,b) => a.CompareTo(b));

        static ComparerProxy<double> Compare64f()
            => new ComparerProxy<double>((a,b) => a.CompareTo(b));
    }
}
