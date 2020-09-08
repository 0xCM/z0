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
    public struct AsmOperandInfo
    {
        /// <summary>
        /// The 0-based operand position
        /// </summary>
        public byte Index;

        /// <summary>
        /// Classifies the operand
        /// </summary>
        public OpKind Kind;

        /// <summary>
        /// Operand immediate info, if applicable
        /// </summary>
        public ImmInfo ImmInfo;

        /// <summary>
        /// Operand memory info, if applicable
        /// </summary>
        public MemInfo Memory;

        /// <summary>
        /// Operand register info, if applicable
        /// </summary>
        public IceRegister Register;

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public AsmBranchInfo Branch;

        [MethodImpl(Inline)]
        public AsmOperandInfo(int index, OpKind kind, in ImmInfo imm, in MemInfo memory, in IceRegister register, AsmBranchInfo branch)
        {
            Index = (byte)index;
            Kind = kind;
            ImmInfo = imm;
            Memory = memory;
            Register = register;
            Branch = branch;
        }
    }
}