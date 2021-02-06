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
    /// Classifies the accessible control registers
    /// </summary>
    public enum ControlRegKind : uint
    {
        CR0 = r0 | Control << ClassField | W64 << WidthField,

        CR2 = r2 | Control << ClassField | W64 << WidthField,

        CR3 = r3 | Control << ClassField | W64 << WidthField,

        CR4 = r4 | Control << ClassField | W64 << WidthField,

        CR8 = r8 | Control << ClassField | W64 << WidthField,
    }
}