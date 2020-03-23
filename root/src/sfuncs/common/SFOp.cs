//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a structural unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISUnaryOp<A> : ISFunc<A,A>
    {
        new UnaryOp<A> Operation => (this as ISFunc<A,A>).Operation.ToUnaryOp();
    }

    /// <summary>
    /// Characterizes a structural binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISBinaryOp<A> : ISFunc<A,A,A>
    {
        new BinaryOp<A> Operation => (this as ISFunc<A,A,A>).Operation.ToBinaryOp();
    }

    /// <summary>
    /// Characterizes a structural binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISTernaryOp<A> : ISFunc<A,A,A,A>
    {
        new TernaryOp<A> Operation => (this as ISFunc<A,A,A,A>).Operation.ToTernaryOp();
    }

}