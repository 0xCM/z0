//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a literal value which, by definition, is a named constant
    /// </summary>
    public readonly struct Literal
    {
        public string Name {get;}

        public Constant Value {get;}

        [MethodImpl(Inline)]
        public Literal(string id, Constant value)
        {
            Name = id;
            Value = value;
        }
    }

    /// <summary>
    /// Defines a literal value which, by definition, is a named constant
    /// </summary>
    public readonly struct Literal<T>
    {
        public string Name {get;}

        public Constant<T> Value {get;}

        [MethodImpl(Inline)]
        public Literal(string id, Constant<T> value)
        {
            Name = id;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator Literal(Literal<T> src)
            => new Literal(src.Name, src.Value);
    }
}