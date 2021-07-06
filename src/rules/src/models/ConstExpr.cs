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
        public readonly struct ConstExpr<S,T> : IConstExpr<ConstExpr<S,T>,T>
        {
            public string Name {get;}

            public S Source {get;}

            public T Value {get;}

            public ConstantKind Kind {get;}

            [MethodImpl(Inline)]
            public ConstExpr(string name, S src, T value, ConstantKind kind)
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
}