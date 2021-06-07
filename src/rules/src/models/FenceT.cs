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

            public string Format<S>(S content)
                => string.Format("{0}{1}{2}", Left, content, Right);

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
    }
}