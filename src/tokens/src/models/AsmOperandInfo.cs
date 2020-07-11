//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes an operand in the context of an assembly instruction
    /// </summary>
    public readonly struct AsmOperandInfo 
    {                        
        /// <summary>
        /// The 0-based operand position
        /// </summary>
        public readonly byte Index;

        /// <summary>
        /// Classifies the operand
        /// </summary>
        public readonly OpKind Kind;

        /// <summary>
        /// Operand immediate info, if applicable
        /// </summary>
        public readonly AsmImmInfo ImmInfo;

        /// <summary>
        /// Operand memory info, if applicable
        /// </summary>
        public readonly AsmMemInfo Memory;
        
        /// <summary>
        /// Operand register info, if applicable
        /// </summary>
        public readonly Register Register;

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public readonly AsmBranchInfo Branch;

        [MethodImpl(Inline)]
        public AsmOperandInfo(int index, OpKind kind, in AsmImmInfo imminfo, in AsmMemInfo memory, 
            in Register register, AsmBranchInfo branch)
        {
            Index = (byte)index;
            Kind = kind;
            ImmInfo = imminfo;
            Memory = memory;
            Register = register;
            Branch = branch;
        }
    }
}