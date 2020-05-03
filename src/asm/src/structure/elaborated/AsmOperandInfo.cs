//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static OpKind;

    /// <summary>
    /// Describes an operand in the context of an assembly instruction
    /// </summary>
    public readonly struct AsmOperandInfo 
    {
        [MethodImpl(Inline)]
        public static AsmOperandInfo Define(int index, OpKind kind, in AsmImmInfo imminfo, in AsmMemInfo memory, 
            in Register register, IAsmBranch branch)
                => new AsmOperandInfo(index, kind, imminfo, memory, register, branch);
                
        [MethodImpl(Inline)]
        public AsmOperandInfo(int index, OpKind kind, in AsmImmInfo imminfo, in AsmMemInfo memory, 
            in Register register, IAsmBranch branch)
        {
            this.Index = (byte)index;
            this.Kind = kind;
            this.ImmInfo = imminfo;
            this.Memory = memory;
            this.Register = register;
            this.Branch = branch;
        }
        
        /// <summary>
        /// The 0-based operand position
        /// </summary>
        public byte Index {get;}

        /// <summary>
        /// Classifies the operand
        /// </summary>
        public OpKind Kind {get;}

        /// <summary>
        /// Operand immediate info, if applicable
        /// </summary>
        public AsmImmInfo ImmInfo {get;}

        /// <summary>
        /// Operand memory info, if applicable
        /// </summary>
        public AsmMemInfo Memory {get;}
        
        /// <summary>
        /// Operand register info, if applicable
        /// </summary>
        public Register Register {get;}

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public IAsmBranch Branch {get;}
    }
}