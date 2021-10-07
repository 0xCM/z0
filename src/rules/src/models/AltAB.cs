//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct RuleModels
    {
        /// <summary>
        /// Defines two potential choices
        /// </summary>
        public readonly struct Alt<A,B>
        {
            public A Left {get;}

            public B Right {get;}

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

            [MethodImpl(Inline)]
            public static implicit operator Alt<A,B>(Paired<A,B> src)
                => new Alt<A,B>(src);

            [MethodImpl(Inline)]
            public static implicit operator Alt<A,B>((A left, B right) src)
                => new Alt<A,B>(src);
        }
    }
}