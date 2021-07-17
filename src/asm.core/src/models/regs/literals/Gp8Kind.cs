//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegFacets;
    using static RegIndexCode;
    using static RegClassCode;
    using static RegWidthCode;

    /// <summary>
    /// Defines classifiers for <see cref='GP'/> registers of width <see cref='W8'/>
    /// </summary>
    public enum Gp8Kind : ushort
    {
        AL = r0 | (GP << ClassField) | (W8 << WidthField),

        AH = r0 | (GP << ClassField) | (W8 << WidthField) | Hi,

        CL = r1 | (GP << ClassField) | (W8 << WidthField),

        CH = r1 | (GP << ClassField) | (W8 << WidthField) | Hi,

        DL = r2 | (GP << ClassField) | (W8 << WidthField),

        DH = r2 | (GP << ClassField) | (W8 << WidthField) | Hi,

        BL = r3 | (GP << ClassField) | (W8 << WidthField),

        BH = r3 | (GP << ClassField) | (W8 << WidthField) | Hi,

        SPL = r4 | (GP << ClassField) | (W8 << WidthField),

        BPL = r5 | (GP << ClassField) | (W8 << WidthField),

        SIL = r6 | (GP << ClassField) | (W8 << WidthField),

        DIL = r7 | (GP << ClassField) | (W8 << WidthField),

        R8B = r8 | (GP << ClassField) | (W8 << WidthField),

        R9B = r9 | (GP << ClassField) | (W8 << WidthField),

        R10B = r10 | (GP << ClassField) | (W8 << WidthField),

        R11B = r11 | (GP << ClassField) | (W8 << WidthField),

        R12B = r12 | (GP << ClassField) | (W8 << WidthField),

        R13B = r13 | (GP << ClassField) | (W8 << WidthField),

        R14B = r14 | (GP << ClassField) | (W8 << WidthField),

        R15B = r15 | (GP << ClassField) | (W8 << WidthField),
    }
}