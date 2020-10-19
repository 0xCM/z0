//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterBitFields;
    using static RegisterIndex;
    using static RegisterClass;
    using static RegisterWidth;

    /// <summary>
    /// Defines classifiers for <see cref='GP'/> and <see cref='GPN'/> registers of width <see cref='W32'/>
    /// </summary>
    public enum Gp32Kind : uint
    {
        EAX = r0 | GP << ClassIndex | W32 << WidthIndex,

        ECX = r1 | GP << ClassIndex | W32 << WidthIndex,

        EDX = r2 | GP << ClassIndex | W32 << WidthIndex,

        EBX = r3 | GP << ClassIndex | W32 << WidthIndex,

        ESP = r4 | GP << ClassIndex | W32 << WidthIndex,

        EBP = r5 | GP << ClassIndex | W32 << WidthIndex,

        ESI = r6 | GP << ClassIndex | W32 << WidthIndex,

        EDI = r7 | GP << ClassIndex | W32 << WidthIndex,

        R8D = r0 | GPN << ClassIndex | W32 << WidthIndex,

        R9D = r1 | GPN << ClassIndex | W32 << WidthIndex,

        R10D = r2 | GPN << ClassIndex | W32 << WidthIndex,

        R11D = r3 | GPN << ClassIndex | W32 << WidthIndex,

        R12D = r4 | GPN << ClassIndex | W32 << WidthIndex,

        R13D = r5 | GPN << ClassIndex | W32 << WidthIndex,

        R14D = r6 | GPN << ClassIndex | W32 << WidthIndex,

        R15D = r7 | GPN << ClassIndex | W32 << WidthIndex,
    }
}