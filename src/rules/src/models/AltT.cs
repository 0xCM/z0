//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines two potential choices
        /// </summary>
        public readonly struct Alt<T> : IRule<Alt<T>,T>
        {
            public T Left {get;}

            public T Right {get;}

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
            public static implicit operator Alt<T>((T left, T right) src)
                => new Alt<T>(src);
        }
    }
}