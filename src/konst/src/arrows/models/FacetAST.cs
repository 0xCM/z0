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

    public readonly struct Facet<A,S,T>
    {
        public readonly asci32 Name;

        public readonly A Value;

        [MethodImpl(Inline)]
        public static implicit operator Facet<A,S,T>(Paired<asci32,A> src)
            => new Facet<A,S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public Facet(asci32 name, A value)
        {
            Name = name;
            Value = value;
        }
    }
}