//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IInstruction
    {
        
    }

    public interface IOperand
    {
        
    }

    public interface ICommand<I,S,T>
        where I : IInstruction
        where S : IOperand
        where T : IOperand
    {
        /// <summary>
        /// The instruction
        /// </summary>
        I Instruction {get;}
        
        /// <summary>
        /// The source operand
        /// </summary>
        S Source {get;}

        /// <summary>
        /// The target operand
        /// </summary>
        T Target {get;}
    }

    public readonly struct Command<I,S,T> : ICommand<I,S,T>
        where I : IInstruction
        where S : IOperand
        where T : IOperand
    {
        /// <summary>
        /// The instruction
        /// </summary>
        public I Instruction {get;}
        
        /// <summary>
        /// The source operand
        /// </summary>
        public S Source {get;}

        /// <summary>
        /// The target operand
        /// </summary>
        public T Target {get;}

    }

}