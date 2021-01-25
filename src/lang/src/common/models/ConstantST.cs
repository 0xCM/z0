//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Constant<S,T> : IConstant<Constant<S,T>,T>
    {
        public Identifier Name {get;}

        public S Source {get;}

        public T Value {get;}

        public ClrLiteralKind Kind {get;}

        [MethodImpl(Inline)]
        public Constant(string name, S src, T value, ClrLiteralKind kind)
        {
            Name = name;
            Source = src;
            Value = value;
            Kind = kind;
        }

        public string Format()
            => Value?.ToString() ?? EmptyString;

        public override string ToString()
            => Format();
   }
}