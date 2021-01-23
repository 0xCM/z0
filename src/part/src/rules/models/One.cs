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
        public readonly struct One
        {
            public dynamic Value {get;}

            [MethodImpl(Inline)]
            public One(dynamic src)
            {
                Value = src;
            }
        }

        /// <summary>
        /// Just one, neither more nor less
        /// </summary>
        public readonly struct One<T>
        {
            public T Value {get;}

            [MethodImpl(Inline)]
            public One(T src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator One<T>(T src)
                => new One<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator One(One<T> src)
                => new One(src.Value);
        }
    }
}