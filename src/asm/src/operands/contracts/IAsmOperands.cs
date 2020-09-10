//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IAsmOperands
    {
        /// <summary>
        /// The instruction operands
        /// </summary>
        IAsmOperand[] Args {get;}

        /// <summary>
        /// The number of arguments accepted by the operand
        /// </summary>
        int Arity => Args.Length;
    }

    /// <summary>
    /// Characterizes an instruction reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IAsmOperands<F> : IAsmOperands
        where F : struct, IAsmOperands<F>
    {
    }
}