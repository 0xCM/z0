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

    public readonly struct Fence : ITextual
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
        public string Format()
            => format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Fence(Pair<char> src)
            => new Fence(src);

        [MethodImpl(Inline)]
        public static implicit operator Fence(Fence<char> src)
            => new Fence(src.Left, src.Right);
    }

}