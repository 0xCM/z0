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
        /// Defines a sequence of potential choices
        /// </summary>
        public readonly struct Alternative<T>
            where T : IEquatable<T>
        {
            public ExactlyOne<T> Left {get;}

            public ExactlyOne<T> Right {get;}

            [MethodImpl(Inline)]
            public Alternative(T left, T right)
            {
                Left = left;
                Right = right;
            }

            [MethodImpl(Inline)]
            public Alternative(Pair<T> src)
            {
                Left = src.Left;
                Right = src.Right;
            }

            [MethodImpl(Inline)]
            public static implicit operator Alternative<T>(Pair<T> src)
                => new Alternative<T>(src);
        }
    }
}