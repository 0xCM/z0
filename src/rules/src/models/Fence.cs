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
        /// Defines a 1-dimensional enclosure
        /// </summary>
        public readonly struct Fence : IRule<Fence>
        {
            public dynamic Left {get;}

            public dynamic Right {get;}

            [MethodImpl(Inline)]
            public Fence(dynamic left, dynamic right)
            {
                Left = left;
                Right = right;
            }

            public string Format()
                => string.Format("{0}..{1}", Left, Right);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Fence((dynamic left, dynamic right) src)
                => new Fence(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Fence(Pair<dynamic> src)
                => new Fence(src.Left, src.Right);
        }

        public readonly struct Fence<T> : IRule<Fence<T>,T>
        {
            public T Left {get;}

            public T Right {get;}

            [MethodImpl(Inline)]
            public Fence(T left, T right)
            {
                Left = left;
                Right = right;
            }

            public string Format()
                => string.Format("{0}..{1}", Left, Right);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Fence<T>((T left, T right) src)
                => new Fence<T>(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Fence<T>(Pair<T> src)
                => new Fence<T>(src.Left, src.Right);

            [MethodImpl(Inline)]
            public static implicit operator Fence(Fence<T> src)
                => new Fence(src.Left, src.Right);
        }

        public readonly struct Fence<A,B> : IRule<Fence<A,B>,A,B>
        {
            public A Left {get;}

            public B Right {get;}

            [MethodImpl(Inline)]
            public Fence(A left, B right)
            {
                Left = left;
                Right = right;
            }

            public string Format()
                => string.Format("{0}..{1}", Left, Right);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Fence<A,B>((A left, B right) src)
                => new Fence<A,B>(src.left, src.right);

            [MethodImpl(Inline)]
            public static implicit operator Fence<A,B>(Paired<A,B> src)
                => new Fence<A,B>(src.Left, src.Right);

            [MethodImpl(Inline)]
            public static implicit operator Fence(Fence<A,B> src)
                => new Fence(src.Left, src.Right);
        }
    }
}