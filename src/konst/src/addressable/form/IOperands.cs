//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IOperands
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
    public interface IOperands<F> : IOperands
        where F : struct, IOperands<F>
    {
    }
}