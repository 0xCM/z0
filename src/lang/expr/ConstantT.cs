//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a compile-time literal value
    /// </summary>
    public readonly struct Constant<T> : IExpr
    {
        public T Value {get;}

        [MethodImpl(Inline)]
        public Constant(T value)
        {
            Value = value;
        }

        public string Format()
            => Value?.ToString() ?? RP.Empty;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Constant<T>(T src)
            => new Constant<T>(src);
    }
}