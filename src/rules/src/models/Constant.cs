//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using Z0.Lang;

    partial struct Rules
    {
        public readonly struct Constant
        {
            public dynamic Value {get;}

            public ConstantKind Kind {get;}

            [MethodImpl(Inline)]
            public Constant(dynamic value, ConstantKind kind)
            {
                Value = value;
                Kind = kind;
            }
        }

        /// <summary>
        /// Defines a compile-time literal value
        /// </summary>
        public readonly struct Constant<T> : IConstant<T>
        {
            public T Value {get;}

            public ConstantKind Kind {get;}

            [MethodImpl(Inline)]
            public Constant(T value, ConstantKind kind)
            {
                Value = value;
                Kind = kind;
            }

            public string Format()
                => Value?.ToString() ?? EmptyString;

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Constant(Constant<T> src)
                => new Constant(src.Value, src.Kind);
        }
    }
}