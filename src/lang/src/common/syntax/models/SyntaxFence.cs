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

    public readonly struct SyntaxFence : ITextual
    {
        public char Left {get;}

        public char Right {get;}

        [MethodImpl(Inline)]
        public SyntaxFence(char left, char right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public SyntaxFence(Pair<char> src)
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
        public static implicit operator SyntaxFence(Pair<char> src)
            => new SyntaxFence(src);

        [MethodImpl(Inline)]
        public static implicit operator SyntaxFence(SyntaxFence<char> src)
            => new SyntaxFence(src.Left, src.Right);
    }

}