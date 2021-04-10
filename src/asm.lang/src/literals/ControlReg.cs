//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmX
    {
        /// <summary>
        /// Specifies the accessible control registers
        /// </summary>
        [SymbolSource]
        public enum ControlReg : byte
        {
            [Symbol("cr0")]
            CR0 = r0,

            [Symbol("cr2")]
            CR2 = r2,

            [Symbol("cr3")]
            CR3 = r3,

            [Symbol("cr4")]
            CR4 = r4,

            [Symbol("cr8")]
            CR8 = r8,
        }
    }
}