//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = SyntaxModels;

    public readonly struct FenceSyntax<T> : ITextual
    {
        public T Left {get;}

        public T Right {get;}

        [MethodImpl(Inline)]
        public FenceSyntax(T left, T right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public FenceSyntax(Pair<T> src)
        {
            Left = src.Left;
            Right = src.Right;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator FenceSyntax<T>(Pair<T> src)
            => new FenceSyntax<T>(src);
    }
}