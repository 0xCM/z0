//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Constant<T> : IConstant<Constant<T>,T>
    {
        public Identifier Name {get;}

        public T Value {get;}

        public LiteralKind Kind {get;}

        [MethodImpl(Inline)]
        public Constant(string name, T value, LiteralKind kind)
        {
            Name = name;
            Value = value;
            Kind = kind;
        }
    }
}