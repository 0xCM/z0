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

    public readonly struct NeedAttribute<N,A,S,T>
    {
        public readonly N Name;

        public readonly A Value;

        [MethodImpl(Inline)]
        public static implicit operator NeedAttribute<N,A,S,T>(Paired<N,A> src)
            => new NeedAttribute<N,A,S,T>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public NeedAttribute(N name, A value)
        {
            Name = name;
            Value = value;
        }
    }
}