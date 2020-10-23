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
    /// Defines <see cref='YMM'/> register classifiers
    /// </summary>
    public enum YmmRegKind : uint
    {
        YMM0 = r0 | YMM << ClassIndex | W256 << WidthIndex,

        YMM1 = r1 | YMM << ClassIndex | W256 << WidthIndex,

        YMM2 = r2 | YMM << ClassIndex | W256 << WidthIndex,

        YMM3 = r3 | YMM << ClassIndex | W256 << WidthIndex,

        YMM4 = r4 | YMM << ClassIndex | W256 << WidthIndex,

        YMM5 = r5 | YMM << ClassIndex | W256 << WidthIndex,

        YMM6 = r6 | YMM << ClassIndex | W256 << WidthIndex,

        YMM7 = r7 | YMM << ClassIndex | W256 << WidthIndex,

        YMM8 = r8 | YMM << ClassIndex | W256 << WidthIndex,

        YMM9 = r9 | YMM << ClassIndex | W256 << WidthIndex,

        YMM10 = r10 | YMM << ClassIndex | W256 << WidthIndex,

        YMM11 = r11 | YMM << ClassIndex | W256 << WidthIndex,

        YMM12 = r12 | YMM << ClassIndex | W256 << WidthIndex,

        YMM13 = r13 | YMM << ClassIndex | W256 << WidthIndex,

        YMM14 = r14 | YMM << ClassIndex | W256 << WidthIndex,

        YMM15 = r15 | YMM << ClassIndex | W256 << WidthIndex,

        YMM16 = r16 | YMM << ClassIndex | W256 << WidthIndex,

        YMM17 = r17 | YMM << ClassIndex | W256 << WidthIndex,

        YMM18 = r18 | YMM << ClassIndex | W256 << WidthIndex,

        YMM19 = r19 | YMM << ClassIndex | W256 << WidthIndex,

        YMM20 = r20 | YMM << ClassIndex | W256 << WidthIndex,

        YMM21 = r21 | YMM << ClassIndex | W256 << WidthIndex,

        YMM22 = r22 | YMM << ClassIndex | W256 << WidthIndex,

        YMM23 = r23 | YMM << ClassIndex | W256 << WidthIndex,

        YMM24 = r24 | YMM << ClassIndex | W256 << WidthIndex,

        YMM25 = r25 | YMM << ClassIndex | W256 << WidthIndex,

        YMM26 = r26 | YMM << ClassIndex | W256 << WidthIndex,

        YMM27 = r27 | YMM << ClassIndex | W256 << WidthIndex,

        YMM28 = r28 | YMM << ClassIndex | W256 << WidthIndex,

        YMM29 = r29 | YMM << ClassIndex | W256 << WidthIndex,

        YMM30 = r30 | YMM << ClassIndex | W256 << WidthIndex,

        YMM31 = r31 | YMM << ClassIndex | W256 << WidthIndex,
    }
}