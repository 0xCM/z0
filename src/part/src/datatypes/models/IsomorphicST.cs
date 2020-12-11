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
        public static Isomorphic Untyped => new Isomorphic(typeof(S), typeof(T));

        [MethodImpl(Inline)]
        public static implicit operator Isomorphic(Isomorphic<S,T> x)
            => Untyped;

        public string Format()
            => Untyped.Format();

        public override string ToString()
            => Format();
    }
}