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

    partial struct ParseDomain
    {
        public readonly struct Fence
        {
            public char Left {get;}

            public char Right {get;}

            [MethodImpl(Inline)]
            public Fence(char left, char right)
            {
                Left = left;
                Right = right;
            }

            [MethodImpl(Inline)]
            public Fence(Pair<char> src)
            {
                Left = src.Left;
                Right = src.Right;
            }

            [MethodImpl(Inline)]
            public static implicit operator Fence(Pair<char> src)
                => new Fence(src);

            [MethodImpl(Inline)]
            public static implicit operator Fence(Fence<char> src)
                => new Fence(src.Left, src.Right);
        }

        public readonly struct Fence<T>
            where T : unmanaged
        {
            public T Left {get;}

            public T Right {get;}

            public Fence(T left, T right)
            {
                Left = left;
                Right = right;
            }

            public Fence(Pair<T> src)
            {
                Left = src.Left;
                Right = src.Right;
            }

            [MethodImpl(Inline)]
            public static implicit operator Fence<T>(Pair<T> src)
                => new Fence<T>(src);
        }

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