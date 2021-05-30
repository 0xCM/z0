//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegFacets;
    using static RegIndex;
    using static RegClass;
    using static RegWidth;

    /// <summary>
    /// Classifies the accessible control registers
    /// </summary>
    public enum ControlRegKind : uint
    {
        CR0 = r0 | Control << ClassField | W64 << WidthField,

        CR1 = r1 | Control << ClassField | W64 << WidthField,

        CR2 = r2 | Control << ClassField | W64 << WidthField,

        CR3 = r3 | Control << ClassField | W64 << WidthField,

        CR4 = r4 | Control << ClassField | W64 << WidthField,

        CR5 = r5 | Control << ClassField | W64 << WidthField,

        CR6 = r6 | Control << ClassField | W64 << WidthField,

        CR7 = r7 | Control << ClassField | W64 << WidthField,
    }
}