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
    /// Defines <see cref='XMM'/> register classifiers
    /// </summary>
    public enum XmmRegKind : uint
    {
        XMM0 = r0 | XMM << ClassIndex | W128 << WidthIndex,

        XMM1 = r1 | XMM << ClassIndex | W128 << WidthIndex,

        XMM2 = r2 | XMM << ClassIndex | W128 << WidthIndex,

        XMM3 = r3 | XMM << ClassIndex | W128 << WidthIndex,

        XMM4 = r4 | XMM << ClassIndex | W128 << WidthIndex,

        XMM5 = r5 | XMM << ClassIndex | W128 << WidthIndex,

        XMM6 = r6 | XMM << ClassIndex | W128 << WidthIndex,

        XMM7 = r7 | XMM << ClassIndex | W128 << WidthIndex,

        XMM8 = r8 | XMM << ClassIndex | W128 << WidthIndex,

        XMM9 = r9 | XMM << ClassIndex | W128 << WidthIndex,

        XMM10 = r10 | XMM << ClassIndex | W128 << WidthIndex,

        XMM11 = r11 | XMM << ClassIndex | W128 << WidthIndex,

        XMM12 = r12 | XMM << ClassIndex | W128 << WidthIndex,

        XMM13 = r13 | XMM << ClassIndex | W128 << WidthIndex,

        XMM14 = r14 | XMM << ClassIndex | W128 << WidthIndex,

        XMM15 = r15 | XMM << ClassIndex | W128 << WidthIndex,

        XMM16 = r16 | XMM << ClassIndex | W128 << WidthIndex,

        XMM17 = r17 | XMM << ClassIndex | W128 << WidthIndex,

        XMM18 = r18 | XMM << ClassIndex | W128 << WidthIndex,

        XMM19 = r19 | XMM << ClassIndex | W128 << WidthIndex,

        XMM20 = r20 | XMM << ClassIndex | W128 << WidthIndex,

        XMM21 = r21 | XMM << ClassIndex | W128 << WidthIndex,

        XMM22 = r22 | XMM << ClassIndex | W128 << WidthIndex,

        XMM23 = r23 | XMM << ClassIndex | W128 << WidthIndex,

        XMM24 = r24 | XMM << ClassIndex | W128 << WidthIndex,

        XMM25 = r25 | XMM << ClassIndex | W128 << WidthIndex,

        XMM26 = r26 | XMM << ClassIndex | W128 << WidthIndex,

        XMM27 = r27 | XMM << ClassIndex | W128 << WidthIndex,

        XMM28 = r28 | XMM << ClassIndex | W128 << WidthIndex,

        XMM29 = r29 | XMM << ClassIndex | W128 << WidthIndex,

        XMM30 = r30 | XMM << ClassIndex | W128 << WidthIndex,

        XMM31 = r31 | XMM << ClassIndex | W128 << WidthIndex,
    }
}