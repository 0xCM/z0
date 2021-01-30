//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        public readonly struct Alt : IRule<Alt>
        {
            public One Left {get;}

            public One Right {get;}

            [MethodImpl(Inline)]
            public Alt(One left, One right)
            {
                Left = left;
                Right = right;
            }
        }

        /// <summary>
        /// Defines two potential choices
        /// </summary>
        public readonly struct Alt<T> : IRule<Alt<T>,T>
        {
            public One<T> Left {get;}

            public One<T> Right {get;}

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

            [MethodImpl(Inline)]
            public static implicit operator Alt<T>(Pair<T> src)
                => new Alt<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator Alt(Alt<T> src)
                => new Alt(src.Left, src.Right);
        }

        /// <summary>
        /// Defines two potential choices
        /// </summary>
        public readonly struct Alt<A,B> : IRule<Alt<A,B>,A,B>
        {
            public One<A> Left {get;}

            public One<B> Right {get;}

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
            public static implicit operator Alt(Alt<A,B> src)
                => new Alt(src.Left, src.Right);
        }
    }
}