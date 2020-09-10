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

    public readonly struct NeedFacet<A,S,T>
    {
        public readonly asci32 Name;

        public readonly A Value;

        [MethodImpl(Inline)]
        public static implicit operator NeedFacet<A,S,T>(Paired<asci32,A> src)
            => new NeedFacet<A,S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public NeedFacet(asci32 name, A value)
        {
            Name = name;
            Value = value;
        }
    }
}