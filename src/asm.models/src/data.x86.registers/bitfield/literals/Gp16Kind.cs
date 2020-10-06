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
    /// Defines classifiers for <see cref='GP'/> and <see cref='GPN'/> registers of width <see cref='W16'/>
    /// </summary>
    public enum Gp16Kind : uint
    {
        AX = r0 | GP << ClassIndex | W16 << WidthIndex,

        CX = r1 | GP << ClassIndex | W16 << WidthIndex,

        DX = r2 | GP << ClassIndex | W16 << WidthIndex,

        BX = r3 | GP << ClassIndex | W16 << WidthIndex,

        SP = r4 | GP << ClassIndex | W16 << WidthIndex,

        BP = r5 | GP << ClassIndex | W16 << WidthIndex,

        SI = r6 | GP << ClassIndex | W16 << WidthIndex,

        DI = r7 | GP << ClassIndex | W16 << WidthIndex,

        R8W = r0 | GPN << ClassIndex | W16 << WidthIndex,

        R9W = r1 | GPN << ClassIndex | W16 << WidthIndex,

        R10W = r2 | GPN << ClassIndex | W16 << WidthIndex,

        R11W = r3 | GPN << ClassIndex | W16 << WidthIndex,

        R12W = r4 | GPN << ClassIndex | W16 << WidthIndex,

        R13W = r5 | GPN << ClassIndex | W16 << WidthIndex,

        R14W = r6 | GPN << ClassIndex | W16 << WidthIndex,

        R15W = r7 | GPN << ClassIndex | W16 << WidthIndex,
    }
}