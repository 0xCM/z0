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

    public readonly struct NeedAttribute<A,S,T>
    {
        public readonly asci32 Name;

        public readonly A Value;

        [MethodImpl(Inline)]
        public static implicit operator NeedAttribute<A,S,T>(Paired<asci32,A> src)
            => new NeedAttribute<A,S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public NeedAttribute(asci32 name, A value)
        {
            Name = name;
            Value = value;
        }
    }
}