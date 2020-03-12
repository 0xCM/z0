//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;

    /// <summary>
    /// Characterizes a unary operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8UnaryOp<A> : IFunc<A,byte,A>
    {
        FunctionClass IFunc.Class => FunctionClass.BinaryImm;
    }

    /// <summary>
    /// Characterizes a unary operator that accepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8x2UnaryOp<A> : IFunc<A,byte,byte,A>
    {
        FunctionClass IFunc.Class => FunctionClass.TernaryImm;
    }

    /// <summary>
    /// Characterizes a bitwise shift operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8ShiftOp<A> : IImm8UnaryOp<A>
    {

    }    

    /// <summary>
    /// Characterizes a binary operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IImm8BinOp<A> : IFunc<A,A,byte,A>
    {

    }    
}