//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Constant<S,T> : IDerivedConstant<S,T>
    {
        public Identifier Name {get;}

        public S Source {get;}

        public T Value {get;}

        public LiteralKind Kind {get;}

        [MethodImpl(Inline)]
        public Constant(string name, S src, T value, LiteralKind kind)
        {
            Name = name;
            Source = src;
            Value = value;
            Kind = kind;
        }
    }
}