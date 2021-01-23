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
        /// Defines a 1-dimensional enclosure
        /// </summary>
        public readonly struct Fence<T>
        {
            public T Left {get;}

            public T Right {get;}

            [MethodImpl(Inline)]
            public Fence(T left, T right)
            {
                Left = left;
                Right = right;
            }

            [MethodImpl(Inline)]
            public static implicit operator Fence<T>((T left, T right) src)
                => new Fence<T>(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Fence<T>(Pair<T> src)
                => new Fence<T>(src.Left, src.Right);
        }

        /// <summary>
        /// Defines a 1-dimensional enclosure
        /// </summary>
        public readonly struct Fence
        {
            public dynamic Left {get;}

            public dynamic Right {get;}

            [MethodImpl(Inline)]
            public Fence(dynamic left, dynamic right)
            {
                Left = left;
                Right = right;
            }

            [MethodImpl(Inline)]
            public static implicit operator Fence((dynamic left, dynamic right) src)
                => new Fence(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Fence(Pair<dynamic> src)
                => new Fence(src.Left, src.Right);
        }
    }
}