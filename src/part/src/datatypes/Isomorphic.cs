//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Isomorphic<S,T> : IIsomorphic<Isomorphic<S,T>,S,T>
    {
        [MethodImpl(Inline)]
        public static implicit operator Isomorphic(Isomorphic<S,T> x)
            => new Isomorphic(typeof(S), typeof(T));
    }

    /// <summary>
    /// Captures a <see cref='IIsomorhphic'/> relationship between two types
    /// </summary>
    public readonly struct Isomorphic : IIsomorhphic
    {
        public Type SourceType {get;}

        public Type TargetType {get;}

        [MethodImpl(Inline)]
        public Isomorphic(Type src, Type dst)
        {
            SourceType = src;
            TargetType = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator Isomorphic((Type src, Type dst) x)
            => new Isomorphic(x.src, x.dst);
    }
}