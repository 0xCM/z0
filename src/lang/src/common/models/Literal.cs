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
    /// Represents a named, compile-time literal
    /// </summary>
    public readonly struct Literal<T>
        where T : IComparable<T>
    {
        public Identifier Identifier {get;}

        public T Value {get;}

        [MethodImpl(Inline)]
        public Literal(Identifier id, T value)
        {
            Identifier = id;
            Value = value;
        }
    }
}