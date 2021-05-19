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
        /// Just one, neither more nor less
        /// </summary>
        public readonly struct One : IRule<One>
        {
            public dynamic Element {get;}

            [MethodImpl(Inline)]
            public One(dynamic src)
                => Element = src;
        }

        /// <summary>
        /// Just one, neither more nor less
        /// </summary>
        public readonly struct One<T> : IRule<One<T>,T>
        {
            public T Element {get;}

            [MethodImpl(Inline)]
            public One(T src)
                => Element = src;

            [MethodImpl(Inline)]
            public static implicit operator One<T>(T src)
                => new One<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator One(One<T> src)
                => new One(src.Element);
        }
    }
}