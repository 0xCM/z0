//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct FenceSyntax<T> : ITextual
    {
        public T FirstValue {get;}

        public T LastValue {get;}

        [MethodImpl(Inline)]
        public FenceSyntax(T left, T right)
        {
            FirstValue = left;
            LastValue = right;
        }

        [MethodImpl(Inline)]
        public FenceSyntax(Pair<T> src)
        {
            FirstValue = src.Left;
            LastValue = src.Right;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("[{0},{1}]", FirstValue, LastValue);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator FenceSyntax<T>(Pair<T> src)
            => new FenceSyntax<T>(src);
    }
}