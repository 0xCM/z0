//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    public delegate A Imm8UnaryOp<A>(A a, byte b);

    [SuppressUnmanagedCodeSecurity]
    public delegate A Imm8BinaryOp<A>(A a, A b, byte c);

    [SuppressUnmanagedCodeSecurity]
    public delegate Span<T> Imm8ShiftSpanOp<T>(ReadOnlySpan<T> src, byte imm8, Span<T> dst);
        
    /// <summary>
    /// Marker for a function that accepts an 8-bit immediate value in one or more parameters
    /// </summary>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8Func : IFunc
    {

    }

    /// <summary>
    /// Characterizes a binary function F:A -> byte -> A that accepts an 8-bit 
    /// immediate value in the second parameter. 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    /// <remarks>
    /// Immediates are constant values, embedded directly in an instruction. So, given such a function
    /// when closed over a constant value, it effectively becomes a unary operator. This observation
    /// justifies the contract name
    /// </remarks>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8UnaryOp<A> : IImm8Func, IFunc<A,byte,A>
    {
           
    }

    /// <summary>
    /// Characterizes a ternary function F:A -> A -> byte -> A that accepts an 8-bit 
    /// immediate value in the third parameter. 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8BinOp<A> : IImm8Func, IFunc<A,A,byte,A>
    {

    }    

    /// <summary>
    /// Characterizes a ternary function F:A -> byte -> byte -> A that accepts 8-bit 
    /// immediate values in the second and third parameters. 
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8x2UnaryOp<A> : IImm8Func, IFunc<A,byte,byte,A>
    {

    }

    /// <summary>
    /// Characterizes a shift function F:A -> byte -> A that accepts an 8-bit immediate value in the second parameter
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8ShiftOp<A> : IImm8UnaryOp<A>
    {

    }    

    /// <summary>
    /// Characterizes a span operator that shifts each source element by the same amount
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8ShiftSpanOp<T> : IImm8Func, IShiftSpanOp
    {
        Span<T> Invoke(ReadOnlySpan<T> src, byte imm8, Span<T> dst);

        Imm8ShiftSpanOp<T> Operation => Invoke;
    }
}