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
    using static SyntaxModels;

    public readonly struct Fence<T> : ITextual
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
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Fence<T>(Pair<T> src)
            => new Fence<T>(src);
    }

}