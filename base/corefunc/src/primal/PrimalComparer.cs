//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;
    
    public readonly struct PrimalComparer<T> : IComparer<T>
        where T : unmanaged
    {
        readonly Func<T,T,int> comparer;

        [MethodImpl(Inline)]
        internal PrimalComparer(Func<T,T,int> comparer)
            => this.comparer = comparer;

        [MethodImpl(Inline)]
        public int Compare(T x, T y)
            => comparer(x,y);
    }

    public static class PrimalComparer
    {        

        [MethodImpl(Inline)]
        public static PrimalComparer<T> Get<T>()
            where T : unmanaged
                => comparer<T>();

        [MethodImpl(Inline)]
        static PrimalComparer<T> comparer<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return (PrimalComparer<T>)(object)Compare8u;
            else if(typeof(T) == typeof(ushort))
                return (PrimalComparer<T>)(object)Compare16u;
            else if(typeof(T) == typeof(uint))
                return (PrimalComparer<T>)(object)Compare32u;
            else if(typeof(T) == typeof(ulong))
                return (PrimalComparer<T>)(object)Compare64u;
            else
                return comparer_i<T>();
        }

        [MethodImpl(Inline)]
        static PrimalComparer<T> comparer_i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return (PrimalComparer<T>)(object)Compare8i;
            else if(typeof(T) == typeof(short))
                return (PrimalComparer<T>)(object)Compare16i;
            else if(typeof(T) == typeof(int))
                return (PrimalComparer<T>)(object)Compare32i;
            else if(typeof(T) == typeof(long))
                return (PrimalComparer<T>)(object)Compare64i;
            else
                return comparer_f<T>();
        }


        [MethodImpl(Inline)]
        static PrimalComparer<T> comparer_f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return (PrimalComparer<T>)(object)Compare32f;
            else if(typeof(T) == typeof(double))
                return (PrimalComparer<T>)(object)Compare64f;
            else
                throw unsupported<T>();
        }

        static PrimalComparer<sbyte> Compare8i 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<sbyte>((a,b) => a.CompareTo(b));
        }

        static IComparer<byte> Compare8u 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<byte>((a,b) => a.CompareTo(b));
        }

        static IComparer<short> Compare16i 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<short>((a,b) => a.CompareTo(b));
        }

        static IComparer<ushort> Compare16u 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<ushort>((a,b) => a.CompareTo(b));
        }

        static IComparer<int> Compare32i 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<int>((a,b) => a.CompareTo(b));
        }

        static IComparer<uint> Compare32u 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<uint>((a,b) => a.CompareTo(b));
        }

        static IComparer<long> Compare64i 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<long>((a,b) => a.CompareTo(b));
        }

        static IComparer<ulong> Compare64u 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<ulong>((a,b) => a.CompareTo(b));
        }

        static IComparer<float> Compare32f 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<float>((a,b) => a.CompareTo(b));
        }

        static IComparer<double> Compare64f 
        {
            [MethodImpl(Inline)]
            get => new PrimalComparer<double>((a,b) => a.CompareTo(b));
        }
    }

}