//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Security;
    
    /// <summary>
    /// Characterizes a unary function
    /// </summary>
    /// <typeparam name="A">The source operand type</typeparam>
    /// <typeparam name="B">The target type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryFunc<A,B> : IFunc<A,B>
    {

    }

    /// <summary>
    /// Characterizes a unary operator
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOp<A> : IUnaryFunc<A,A>
    {

    }

    /// <summary>
    /// Characterizes a unary operator that accepts an 8-bit immediate
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOpImm8<A> : IFunc<A,byte,A>
    {
        FunctionClass IFunc.Class => FunctionClass.BinaryImm;
    }


    /// <summary>
    /// Characterizes a unary operator that accepts two 8-bit immediates
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IUnaryOpImm8x2<A> : IFunc<A,byte,byte,A>
    {
        FunctionClass IFunc.Class => FunctionClass.TernaryImm;
    }
}