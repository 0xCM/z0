//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct Facet<S,T> : IFacet<S,T>
    {
        public S Key {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public Facet(S key, T value)
        {
            Key = key;
            Value = value;
        }

        public static implicit operator Facet<S,T>(Paired<S,T> src)
            => new Facet<S,T>(src.Left, src.Right);
    }
}