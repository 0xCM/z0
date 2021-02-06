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
        DR0 = r0 | Debug << ClassField | W64 << WidthField,

        DR1 = r1 | Debug << ClassField | W64 << WidthField,

        DR2 = r2 | Debug << ClassField | W64 << WidthField,

        DR3 = r3 | Debug << ClassField | W64 << WidthField,

        DR6 = r6 | Debug << ClassField | W64 << WidthField,

        DR7 = r7 | Debug << ClassField | W64 << WidthField,
    }
}