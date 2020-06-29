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

}