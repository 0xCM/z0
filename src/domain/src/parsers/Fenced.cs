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

    public readonly partial struct Fenced
    {
        public readonly struct Fence<L,R>
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

            public static implicit operator Fence<L,R>(Paired<L,R> src)
                => new Fence<L,R>(src);
        }
    }
}