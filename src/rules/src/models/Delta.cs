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
        /// Represents the magnitude of the distance between two values with respect to a contectxtual metric
        /// </summary>
        public readonly struct Delta : IRule<Delta>
        {
            public dynamic Left {get;}

            public dynamic Right {get;}

            [MethodImpl(Inline)]
            public Delta(dynamic left, dynamic right)
            {
                Left = left;
                Right = right;
            }

            [MethodImpl(Inline)]
            public static implicit operator Delta((dynamic left, dynamic right) src)
                => new Delta(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Delta(Pair<dynamic> src)
                => new Delta(src.Left, src.Right);

            [MethodImpl(Inline)]
            public static implicit operator Delta<dynamic>(Delta src)
                => new Delta<dynamic>(src.Left, src.Right);
        }

        /// <summary>
        /// Represents the magnitude of the distance between two values with respect to a contectxtual metric
        /// </summary>
        public readonly struct Delta<T> : IRule<Delta<T>,T>
        {
            public T Left {get;}

            public T Right {get;}

            [MethodImpl(Inline)]
            public Delta(T left, T right)
            {
                Left = left;
                Right = right;
            }

            [MethodImpl(Inline)]
            public static implicit operator Delta<T>((T left, T right) src)
                => new Delta<T>(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Delta<T>(Pair<T> src)
                => new Delta<T>(src.Left, src.Right);

            [MethodImpl(Inline)]
            public static implicit operator Delta(Delta<T> src)
                => new Delta(src.Left, src.Right);
        }
    }
}