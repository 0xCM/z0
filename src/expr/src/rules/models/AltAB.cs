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
    public readonly struct Alt<A,B> : IExpr
    {
        public readonly A Left;

        public readonly B Right;

        [MethodImpl(Inline)]
        public Alt(A left, B right)
        {
            Left = left;
            Right = right;
        }

        [MethodImpl(Inline)]
        public Alt(Paired<A,B> src)
        {
            Left = src.Left;
            Right = src.Right;
        }

        public Label Name => "alt<a,b>";
        
        public string Format()
            => rules.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Alt<A,B>(Paired<A,B> src)
            => new Alt<A,B>(src);

        [MethodImpl(Inline)]
        public static implicit operator Alt<A,B>((A left, B right) src)
            => new Alt<A,B>(src);
    }   
}