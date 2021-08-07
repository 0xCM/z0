//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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

        public string Format<T>(T content)
            => string.Format("{0}{1}{2}", Left, content, Right);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Fence((dynamic left, dynamic right) src)
            => new Fence(src.left, src.right);

        [MethodImpl(Inline)]
        public static implicit operator Fence(Pair<dynamic> src)
            => new Fence(src.Left, src.Right);
    }
}