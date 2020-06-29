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
    /// <typeparam name="X0">The operand type</typeparam>
    public interface ICmd<F,X0> : ICmd<F>, INaturalized<N1>
        where X0 : struct, IOperand
        where F : struct, ICmd<F,X0>
    {
        X0 A {get;}

        IOperand[] ICmd.Args 
            => new IOperand[]{A};            
    }

    /// <summary>
    /// An instruction that accepts two operands
    /// </summary>
    /// <typeparam name="X0">The first operand type</typeparam>
    /// <typeparam name="X1">The second operand type</typeparam>
    public interface ICmd<F,X0,X1> : ICmd<F>, INaturalized<N2>
        where F : struct, ICmd<F,X0,X1>
        where X0 : struct, IOperand
        where X1 : struct, IOperand
    {
        X0 A {get;}

        X1 B {get;}

        IOperand[] ICmd.Args 
            => new IOperand[]{A, B};
    }

    /// <summary>
    /// An instruction that accepts three operands
    /// </summary>
    /// <typeparam name="X0">The first operand type</typeparam>
    /// <typeparam name="X1">The second operand type</typeparam>
    /// <typeparam name="X2">The second operand type</typeparam>
    public interface ICmd<F,X0,X1,X2> : ICmd<F>, INaturalized<N3>
        where F : struct, ICmd<F,X0,X1,X2>
        where X0 : struct, IOperand
        where X1 : struct, IOperand
        where X2 : struct, IOperand
    {
        X0 A {get;}

        X1 B {get;}

        X2 C {get;}

        IOperand[] ICmd.Args 
            => new IOperand[]{A, B, C};            
    }
}