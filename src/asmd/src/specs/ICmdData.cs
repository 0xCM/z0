//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using static Seed;

    /// <summary>
    /// Defines facets common to all instructions without regard to arity
    /// </summary>
    public interface ICmdData
    {
        /// <summary>
        /// The instruction operands
        /// </summary>
        IOperand[] Args {get;}

        /// <summary>
        /// The instruction op code
        /// </summary>
        CmdOpCode Code {get;}

        /// <summary>
        /// The number of arguments accepted by the operand
        /// </summary>
        int Arity => Args.Length;
    }

    /// <summary>
    /// Characterizes an instruction reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface ICmdData<F> : ICmdData
        where F : struct, ICmdData<F>
    {
    }

    /// <summary>
    /// An instruction that accepts one operand
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    public interface ICmdData<F,A> : ICmdData<F>, INaturalized<N1>
        where A : struct, IOperand
        where F : struct, ICmdData<F,A>
    {
        A Arg0 {get;}

        IOperand[] ICmdData.Args 
            => new IOperand[]{Arg0};            
    }

    /// <summary>
    /// An instruction that accepts two operands
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    public interface ICmdData<F,A,B> : ICmdData<F>, INaturalized<N2>
        where F : struct, ICmdData<F,A,B>
        where A : struct, IOperand
        where B : struct, IOperand
    {
        A Arg0 {get;}

        B Arg1 {get;}

        IOperand[] ICmdData.Args 
            => new IOperand[]{Arg0, Arg1};
    }

    /// <summary>
    /// An instruction that accepts three operands
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The second operand type</typeparam>
    public interface ICmdData<F,A,B,C> : ICmdData<F>, INaturalized<N3>
        where F : struct, ICmdData<F,A,B,C>
        where A : struct, IOperand
        where B : struct, IOperand
        where C : struct, IOperand
    {
        A Arg0 {get;}

        B Arg1 {get;}

        C Arg2 {get;}

        IOperand[] ICmdData.Args 
            => new IOperand[]{Arg0, Arg1, Arg2};            
    }
}