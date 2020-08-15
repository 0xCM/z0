//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterBitFields;
    using static RegisterCode;
    using static RegisterClass;
    using static RegisterWidth;

    /// <summary>
    /// Defines classifiers for <see cref='GP'/> and <see cref='GPN'/> registers of width <see cref='W8'/>
    /// </summary>
    public enum Gp8Kind : uint
    {
        AL = r0 | GP << ClassIndex | W8 << WidthIndex,

        CL = r1 | GP << ClassIndex | W8 << WidthIndex,

        DL = r2 | GP << ClassIndex | W8 << WidthIndex,

        BL = r3 | GP << ClassIndex | W8 << WidthIndex,

        SPL = r4 | GP << ClassIndex | W8 << WidthIndex,

        BPL = r5 | GP << ClassIndex | W8 << WidthIndex,

        SIL = r6 | GP << ClassIndex | W8 << WidthIndex,

        DIL = r7 | GP << ClassIndex | W8 << WidthIndex,

        R8L = r0 | GPN << ClassIndex | W8 << WidthIndex,

        R9L = r1 | GPN << ClassIndex | W8 << WidthIndex,

        R10L = r2 | GPN << ClassIndex | W8 << WidthIndex,

        R11L = r3 | GPN << ClassIndex | W8 << WidthIndex,

        R12L = r4 | GPN << ClassIndex | W8 << WidthIndex,

        R13L = r5 | GPN << ClassIndex | W8 << WidthIndex,

        R14L = r6 | GPN << ClassIndex | W8 << WidthIndex,

        R15L = r7 | GPN << ClassIndex | W8 << WidthIndex,
    }

}