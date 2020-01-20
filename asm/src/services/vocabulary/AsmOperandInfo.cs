//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes an operand in the context of an assembly instruction
    /// </summary>
    public class AsmOperandInfo
    {
        public static AsmOperandInfo Define(int index, string kind, ImmInfo imminfo, AsmMemInfo memory, AsmRegisterInfo register, AsmBranchInfo branch)
                => new AsmOperandInfo(index, kind, imminfo, memory, register, branch);
        public AsmOperandInfo(int index, string kind, ImmInfo imminfo, AsmMemInfo meminfo, AsmRegisterInfo register, AsmBranchInfo branch)
        {
            this.Index = (byte)index;
            this.Kind = kind;
            this.ImmInfo = imminfo;
            this.Memory = meminfo;
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
        public string Kind {get;}

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