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
        public readonly struct ExactlyOne<T>
        {
            public T Value {get;}

            [MethodImpl(Inline)]
            public ExactlyOne(T src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator ExactlyOne<T>(T src)
                => new ExactlyOne<T>(src);
        }
    }
}