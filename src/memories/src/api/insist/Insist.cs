//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct Insist : IInsist
    {
        public static Insist Service => default(Insist);

        public void insist(bool invariant)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed");
        }

        public void insist(bool invariant, string msg)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed: {msg}");
        }

        [MethodImpl(Inline)]
        public void insist<N>(ulong src)
            where N : unmanaged, ITypeNat
                => insist(value<N>() == src, $"The source value {src} does not match the required natural value {value<N>()}");        

        [MethodImpl(Inline)]
        public void insist<N>(int src)
            where N : unmanaged, ITypeNat
                => insist<N>((ulong)src);
    
        [MethodImpl(Inline)]
        public T insist<T>(T src)
            where T : class
        {
            insist(src != null);
            return src;
        }

        [MethodImpl(Inline)]
        public T insist<T>(T src, Func<T,bool> f)
        {
            insist(f(src));
            return src;
        }
        
        [MethodImpl(Inline)]
        public T insist<T>(T? src)
            where T : struct
        {
            insist(src.HasValue);
            return src.Value;
        }

        [MethodImpl(Inline)]
        public T insist<T>(Option<T> src)
        {
            insist(src.IsSome());
            return src.Value;
        }        

        [MethodImpl(Inline)]
        public T insist<T>(T lhs, T rhs)
            where T : IEquatable<T>            
        {
            if(nullnot(lhs) && nullnot(rhs) && lhs.Equals(rhs))
                return lhs;
            else
                insist(false, $"{lhs} != {rhs}");
            
            return default;
        }

    }
}