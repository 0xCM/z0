//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface ITypedInstruction
    {
        
    }

    public interface ITypedOperand
    {
        
    }

    public interface IAsmCommand<I,S,T>
        where I : ITypedInstruction
        where S : ITypedOperand
        where T : ITypedOperand
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

    public readonly struct Command<I,S,T> : IAsmCommand<I,S,T>
        where I : ITypedInstruction
        where S : ITypedOperand
        where T : ITypedOperand
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