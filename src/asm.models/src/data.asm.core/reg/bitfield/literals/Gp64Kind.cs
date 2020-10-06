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
    /// Defines classifiers for <see cref='GP'/> and <see cref='GPN'/> registers of width <see cref='W64'/>
    /// </summary>
    public enum Gp64Kind : uint
    {
        RAX = r0 | GP << ClassIndex | W64 << WidthIndex,

        RCX = r1 | GP << ClassIndex | W64 << WidthIndex,

        RDX = r2 | GP << ClassIndex | W64 << WidthIndex,

        RBX = r3 | GP << ClassIndex | W64 << WidthIndex,

        RSP = r4 | GP << ClassIndex | W64 << WidthIndex,

        RBP = r5 | GP << ClassIndex | W64 << WidthIndex,

        RSI = r6 | GP << ClassIndex | W64 << WidthIndex,

        RDI = r7 | GP << ClassIndex | W64 << WidthIndex,

        R8Q = r0 | GPN << ClassIndex | W64 << WidthIndex,

        R9Q = r1 | GPN << ClassIndex | W64 << WidthIndex,

        R10Q = r2 | GPN << ClassIndex | W64 << WidthIndex,

        R11Q = r3 | GPN << ClassIndex | W64 << WidthIndex,

        R12Q = r4 | GPN << ClassIndex | W64 << WidthIndex,

        R13Q = r5 | GPN << ClassIndex | W64 << WidthIndex,

        R14Q = r6 | GPN << ClassIndex | W64 << WidthIndex,

        R15Q = r7 | GPN << ClassIndex | W64 << WidthIndex,
    }
}