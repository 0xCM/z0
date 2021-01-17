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
        /// <summary>
        /// Defines two potential choices
        /// </summary>
        public readonly struct Alt<T>
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
        }
    }
}