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

    partial struct SyntaxModels
    {
       public readonly struct Fence<L,R> : ITextual
            where L : unmanaged
            where R : unmanaged
        {
            public L Left {get;}

            public R Right {get;}

            [MethodImpl(Inline)]
            public Fence(L l, R r)
            {
                Left = l;
                Right = r;
            }

            [MethodImpl(Inline)]
            public Fence(Paired<L,R> src)
            {
                Left = src.Left;
                Right = src.Right;
            }

            [MethodImpl(Inline)]
            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Fence<L,R>(Paired<L,R> src)
                => new Fence<L,R>(src);
        }
    }
}