//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Rules
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a literal value which, by definition, is a labeled constant
    /// </summary>
    public readonly struct Literal<T> : ITerm<T>
    {
        public Label Name {get;}

        public Constant<T> Value {get;}

        [MethodImpl(Inline)]
        public Literal(Label name, Constant<T> value)
        {
            Name = name;
            Value = value;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();
    }
}