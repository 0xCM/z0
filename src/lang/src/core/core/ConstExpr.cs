//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Characterizes a reified constant value
    /// </summary>
    /// <typeparam name="T">The constant type</typeparam>
    public interface IConstExpr<H,T> : IConstant<T>, ISyntax<H>
        where H : IConstExpr<H,T>, new()
    {

    }

    public readonly struct ConstExpr<S,T> : IConstExpr<ConstExpr<S,T>,T>
    {
        public Identifier Name {get;}

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