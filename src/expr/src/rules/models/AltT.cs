//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines two potential choices
    /// </summary>
    public readonly struct Alt<T> : IExpr
    {
        public readonly T Left;

        public readonly T Right;

        [MethodImpl(Inline)]
        public Alt(T left, T right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public Alt(Pair<T> src)
        {
            Left = src.Left;
            Right = src.Right;
        }

        public Label Name => "alt<a>";

        public string Format()
            => rules.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Alt<T>(Pair<T> src)
            => new Alt<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Alt<T>((T left, T right) src)
            => new Alt<T>(src);
    }    
}