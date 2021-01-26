//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

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
    }
}