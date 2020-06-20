//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    /// <summary>
    /// Defines facets common to all instructions without regard to arity
    /// </summary>
    public interface ICmd
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
    public interface ICmd<F> : ICmd
        where F : struct, ICmd<F>
    {
    }

    /// <summary>
    /// An instruction that accepts one operand
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    public interface ICmd<F,A> : ICmd<F>, INaturalized<N1>
        where A : struct, IOperand
        where F : struct, ICmd<F,A>
    {
        A Arg0 {get;}

        IOperand[] ICmd.Args 
            => new IOperand[]{Arg0};            
    }

    /// <summary>
    /// An instruction that accepts two operands
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    public interface ICmd<F,A,B> : ICmd<F>, INaturalized<N2>
        where F : struct, ICmd<F,A,B>
        where A : struct, IOperand
        where B : struct, IOperand
    {
        A Arg0 {get;}

        B Arg1 {get;}

        IOperand[] ICmd.Args 
            => new IOperand[]{Arg0, Arg1};
    }

    /// <summary>
    /// An instruction that accepts three operands
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The second operand type</typeparam>
    public interface ICmd<F,A,B,C> : ICmd<F>, INaturalized<N3>
        where F : struct, ICmd<F,A,B,C>
        where A : struct, IOperand
        where B : struct, IOperand
        where C : struct, IOperand
    {
        A Arg0 {get;}

        B Arg1 {get;}

        C Arg2 {get;}

        IOperand[] ICmd.Args 
            => new IOperand[]{Arg0, Arg1, Arg2};            
    }
}