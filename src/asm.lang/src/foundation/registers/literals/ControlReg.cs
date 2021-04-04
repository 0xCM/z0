//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    /// <summary>
    /// Classifies the accessible control registers
    /// </summary>
    public enum ControlReg : byte
    {
        CR0 = r0,

        CR2 = r2,

        CR3 = r3,

        CR4 = r4,

        CR8 = r8,
    }
}