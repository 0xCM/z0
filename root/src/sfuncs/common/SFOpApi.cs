//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISUnaryOpApi<A> : ISFApi<A,A>
    {
        new UnaryOp<A> Operation => (this as ISFApi<A,A>).Operation.ToUnaryOp();
    }

    /// <summary>
    /// Characterizes a structural binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISBinaryOpApi<A> : ISFApi<A,A,A>
    {
        new BinaryOp<A> Operation => (this as ISFApi<A,A,A>).Operation.ToBinaryOp();    
    }

    /// <summary>
    /// Characterizes a structural ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISTernaryOpApi<A> : ISFApi<A,A,A,A>
    {
        new TernaryOp<A> Operation => (this as ISFApi<A,A,A,A>).Operation.ToTernaryOp();
    } 
}