//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Constant<T> : IConstant<Constant<T>,T>
    {
        public Identifier Name {get;}

        public T Value {get;}

        public ClrLiteralKind Kind {get;}

        [MethodImpl(Inline)]
        public Constant(string name, T value, ClrLiteralKind kind)
        {
            Name = name;
            Value = value;
            Kind = kind;
        }

        public string Format()
            => Value?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();

    }
}