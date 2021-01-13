//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public struct AsmOperandInfo
    {
        /// <summary>
        /// The 0-based operand position
        /// </summary>
        public byte Index;

        /// <summary>
        /// Classifies the operand
        /// </summary>
        public byte Kind;

        /// <summary>
        /// Operand immediate info, if applicable
        /// </summary>
        public AsmImmInfo ImmInfo;

        /// <summary>
        /// Operand memory info, if applicable
        /// </summary>
        public IceMemoryInfo Memory;

        /// <summary>
        /// Operand register info, if applicable
        /// </summary>
        public IceRegister Register;

        /// <summary>
        /// Instruction branching info, if applicable
        /// </summary>
        public AsmBranch Branch;
    }
}
