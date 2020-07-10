//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant)
        {
            if(!invariant)
                sys.@throw($"Application invaraiant failed");
        }

        [MethodImpl(Inline), Op]
        public static void insist(bool invariant, string msg)
        {
            if(!invariant)
                sys.@throw(new Exception($"Application invaraiant failed: {msg}"));
        }

        [MethodImpl(Inline)]
        public static ulong insist<N>(ulong src, N n = default)
            where N : unmanaged, ITypeNat
        {
            insist(value<N>() == src, $"The source value {src} does not match the required natural value {value<N>()}");   
            return src;     
        }

        [MethodImpl(Inline)]
        public static int insist<N>(int src, N n = default)
            where N : unmanaged, ITypeNat            
                => (int)insist<N>((ulong)src);

        [MethodImpl(Inline)]
        public static T[] insist<N,T>(T[] src, N n = default)
            where N : unmanaged, ITypeNat
        {
            insist(src.Length,n);
            return src;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T insist<T>(T src, Func<T,bool> f)
        {
            insist(f(src));
            return src;
        }

        [MethodImpl(Inline)]
        public static T insist<T>(T src)
            where T : class
        {
            insist(src != null);
            return src;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T insist<T>(T? src)
            where T : struct
        {
            insist(src.HasValue);
            return src.Value;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T insist<T>(Option<T> src)
        {
            insist(src.IsSome());
            return src.Value;
        }        

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T insist<T>(T lhs, T rhs)
            where T : IEquatable<T>            
        {
            if(z.nullnot(lhs) && z.nullnot(rhs) && lhs.Equals(rhs))
                return lhs;
            else
                insist(false, $"{lhs} != {rhs}");
            
            return default;
        }

    }
}