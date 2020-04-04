//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Describes an operand in the context of an assembly instruction
    /// </summary>
    public class AsmOperandInfo
    {
        public static AsmOperandInfo Define(int index, OpKind kind, 
            in Option<ImmInfo> imminfo, in Option<AsmMemInfo> memory, in Option<AsmRegisterInfo> register, in Option<AsmBranchInfo> branch)
                => new AsmOperandInfo(index, kind, imminfo, memory, register, branch);
        public AsmOperandInfo(int index, OpKind kind, 
            in Option<ImmInfo> imminfo, in Option<AsmMemInfo> memory, in Option<AsmRegisterInfo> register, in Option<AsmBranchInfo> branch)
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
        public Option<ImmInfo> ImmInfo {get;}

        /// <summary>
        /// Operand memory info, if applicable
        /// </summary>
        public Option<AsmMemInfo> Memory {get;}
        
        /// <summary>
        /// Operand register info, if applicable
        /// </summary>
        public Option<AsmRegisterInfo> Register {get;}

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public Option<AsmBranchInfo> Branch {get;}
    }
}