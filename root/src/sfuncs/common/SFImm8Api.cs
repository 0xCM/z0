//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    
    /// <summary>
    /// Characterizes an identified <see cref="ISImm8UnaryOp{A}"/> operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8UnaryOpApi<A> : ISImm8UnaryOp<A>
    {
           
    }

    /// <summary>
    /// Characterizes an identified <see cref="ISImm8BinaryOp{A}"/> operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8BinaryOpApi<A> : ISImm8BinaryOp<A>
    {

    }    

    /// <summary>
    /// Characterizes an identified <see cref="ISImm8x2UnaryOp{A}"/> operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8x2UnaryOpApi<A> : ISImm8x2UnaryOp<A>
    {

    }
}