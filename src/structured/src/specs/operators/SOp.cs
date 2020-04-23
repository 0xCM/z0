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
    public interface ISUnaryOpApi<A> : ISFunc<A,A>
    {
        new UnaryOp<A> Operation => (this as ISFunc<A,A>).Operation.ToUnaryOp();
    }

    /// <summary>
    /// Characterizes a structural binary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISBinaryOpApi<A> : ISFuncApi<A,A,A>
    {
        new BinaryOp<A> Operation => (this as ISFuncApi<A,A,A>).Operation.ToBinaryOp();    
    }

    /// <summary>
    /// Characterizes a structural ternary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISTernaryOpApi<A> : ISFuncApi<A,A,A,A>
    {
        new TernaryOp<A> Operation => (this as ISFuncApi<A,A,A,A>).Operation.ToTernaryOp();
    } 
}