//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Defines facets common to all instructions without regard to arity
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// The instruction operands
        /// </summary>
        IOperand[] Args {get;}

        /// <summary>
        /// The instruction op code
        /// </summary>
        CmdInfo Code {get;}

        /// <summary>
        /// The instruction signature
        /// </summary>            
        OpSig Sig {get;}

        /// <summary>
        /// The number of arguments accepted by the operand
        /// </summary>
        int Arity => Args.Length;
    }

    /// <summary>
    /// Characterizes an instruction reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface ICommand<F> : ICommand
        where F : unmanaged, ICommand<F>
    {
        CmdInfo ICommand.Code 
            => CmdAttribute.TargetOpCode<F>();

        OpSig ICommand.Sig 
            => CmdAttribute.TargetSig<F>();
    }

    /// <summary>
    /// An instruction that accepts one operand
    /// </summary>
    /// <typeparam name="A">The operand type</typeparam>
    public interface ICommand<F,A> : ICommand<F>, INaturalized<N1>
        where A : unmanaged, IOperand
        where F : unmanaged, ICommand<F,A>
    {
        A Arg0 {get;}

        IOperand[] ICommand.Args 
            => new IOperand[]{Arg0};            
    }

    /// <summary>
    /// An instruction that accepts two operands
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    public interface ICommand<F,A,B> : ICommand<F>, INaturalized<N2>
        where F : unmanaged, ICommand<F,A,B>
        where A : unmanaged, IOperand
        where B : unmanaged, IOperand
    {
        A Arg0 {get;}

        B Arg1 {get;}

        IOperand[] ICommand.Args 
            => new IOperand[]{Arg0, Arg1};
    }

    /// <summary>
    /// An instruction that accepts three operands
    /// </summary>
    /// <typeparam name="A">The first operand type</typeparam>
    /// <typeparam name="B">The second operand type</typeparam>
    /// <typeparam name="C">The second operand type</typeparam>
    public interface ICommand<F,A,B,C> : ICommand<F>, INaturalized<N3>
        where F : unmanaged, ICommand<F,A,B,C>
        where A : unmanaged, IOperand
        where B : unmanaged, IOperand
        where C : unmanaged, IOperand
    {
        A Arg0 {get;}

        B Arg1 {get;}

        C Arg2 {get;}

        IOperand[] ICommand.Args 
            => new IOperand[]{Arg0, Arg1, Arg2};            
    }

}