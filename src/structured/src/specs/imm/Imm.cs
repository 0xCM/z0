//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    
    /// <summary>
    /// Characterizes a binary function F:A -> byte -> A that accepts an 8-bit immediate value in the second parameter. 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    /// <remarks>
    /// Immediates are constant values, embedded directly in an instruction. So, given such a function
    /// when closed over a constant value, it effectively becomes a unary operator. This observation
    /// justifies the contract name
    /// </remarks>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8UnaryOpApi<A> :  ISFunc<A,byte,A>
    {
           
    }

    /// <summary>
    /// Characterizes a ternary function F:A -> A -> byte -> A that accepts an 8-bit 
    /// immediate value in the third parameter. 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8BinaryOpApi<A> : ISFuncApi<A,A,byte,A>
    {

    }    

    /// <summary>
    /// Characterizes a ternary function F:A -> byte -> byte -> A that accepts 8-bit 
    /// immediate values in the second and third parameters. 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface ISImm8x2UnaryOpApi<A> : ISFuncApi<A,byte,byte,A>
    {

    }
}