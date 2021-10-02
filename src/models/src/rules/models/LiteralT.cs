//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines a literal value which, by definition, is a labeled constant
        /// </summary>
        public readonly struct Literal<T>
        {
            public Label Name {get;}

            public Constant<T> Value {get;}

            [MethodImpl(Inline)]
            public Literal(Label name, Constant<T> value)
            {
                Name = name;
                Value = value;
            }
        }
    }
}