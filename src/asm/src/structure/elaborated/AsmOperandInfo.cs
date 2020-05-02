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
    public readonly struct AsmOperandInfo : ITextual
    {
        [MethodImpl(Inline)]
        public static AsmOperandInfo Define(int index, OpKind kind, in AsmImmInfo imminfo, in AsmMemInfo memory, 
            in AsmRegisterInfo register, in AsmBranchInfo branch)
                => new AsmOperandInfo(index, kind, imminfo, memory, register, branch);
                
        [MethodImpl(Inline)]
        public AsmOperandInfo(int index, OpKind kind, in AsmImmInfo imminfo, in AsmMemInfo memory, 
            in AsmRegisterInfo register, in AsmBranchInfo branch)
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
        public AsmRegisterInfo Register {get;}

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public AsmBranchInfo Branch {get;}

        public string Format()
        {            
            switch(Kind)
            {
                case OpKind.Register:
                    return Register.Format();
                case MemorySegSI:
                case MemorySegESI:
                case MemorySegRSI:
                case MemorySegDI:
                case MemorySegEDI:
                case MemorySegRDI:
                case MemoryESDI:
                case MemoryESEDI:
                case MemoryESRDI:
                case Memory64:
                case OpKind.Memory:
                    return Memory.Format();
                case NearBranch16:
                case NearBranch32:
                case NearBranch64:
                case FarBranch16:
                case FarBranch32:
                    return Branch.Format();
                case Immediate8:
                case Immediate8_2nd:
                case Immediate16:
                case Immediate32:
                case Immediate64:
                case Immediate8to16:
                case Immediate8to32:
                case Immediate8to64:
                case Immediate32to64:
                    return ImmInfo.Format();
                default:
                    return "missed?";
            }            
        }

/*


*/

    }
}