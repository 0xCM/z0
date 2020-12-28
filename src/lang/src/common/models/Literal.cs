//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents a compile-time literal
    /// </summary>
    public readonly struct Literal<I,T>
    {
        public Identifier<I> Identifier {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public Literal(Identifier<I> id, T value)
        {
            Identifier = id;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Literal<I,T>(Paired<I,T> src)
            => new Literal<I,T>(src.Left, src.Right);
    }
}