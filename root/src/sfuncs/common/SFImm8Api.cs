//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    
    /// <summary>
    /// Characterizes an identified <see cref="ISFImm8UnaryOp{A}"/> operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8UnaryOpApi<A> : ISFImm8UnaryOp<A>
    {
           
    }

    /// <summary>
    /// Characterizes an identified <see cref="ISFImm8BinaryOp{A}"/> operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISFImm8BinaryOpApi<A> : ISFImm8BinaryOp<A>
    {

    }    

    /// <summary>
    /// Characterizes an identified <see cref="ISFImm8x2UnaryOp{A}"/> operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8x2UnaryOpApi<A> : ISFImm8x2UnaryOp<A>
    {

    }
}