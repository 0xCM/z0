//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterBits;
    using static RegIndex;
    using static RegClass;
    using static RegWidth;

    /// <summary>
    /// Classifies the accessible debug registers
    /// </summary>
    public enum DebugRegKind : uint
    {
        DR0 = r0 | Debug << ClassIndex | W64 << WidthIndex,

        DR1 = r1 | Debug << ClassIndex | W64 << WidthIndex,

        DR2 = r2 | Debug << ClassIndex | W64 << WidthIndex,

        DR3 = r3 | Debug << ClassIndex | W64 << WidthIndex,

        DR6 = r6 | Debug << ClassIndex | W64 << WidthIndex,

        DR7 = r7 | Debug << ClassIndex | W64 << WidthIndex,
    }
}