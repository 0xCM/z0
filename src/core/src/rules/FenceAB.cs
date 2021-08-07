//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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

        public string Format<T>(T content)
            => string.Format("{0}{1}{2}", Left, content, Right);

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