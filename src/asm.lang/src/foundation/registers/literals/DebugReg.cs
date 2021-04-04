//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    /// <summary>
    /// Classifies the accessible debug registers
    /// </summary>
    public enum DebugReg : uint
    {
        DR0 = r0,

        DR1 = r1,

        DR2 = r2,

        DR3 = r3,

        DR6 = r6,

        DR7 = r7,
    }
}