//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegisterBits;
    using static RegisterIndex;
    using static RegisterClass;
    using static RegisterWidth;

    /// <summary>
    /// Defines <see cref='ZMM'/> register classifiers
    /// </summary>
    public enum ZmmRegKind : uint
    {
        ZMM0 = r0 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM1 = r1 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM2 = r2 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM3 = r3 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM4 = r4 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM5 = r5 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM6 = r6 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM7 = r7 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM8 = r8 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM9 = r9 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM10 = r10 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM11 = r11 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM12 = r12 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM13 = r13 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM14 = r14 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM15 = r15 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM16 = r16 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM17 = r17 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM18 = r18 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM19 = r19 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM20 = r20 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM21 = r21 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM22 = r22 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM23 = r23 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM24 = r24 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM25 = r25 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM26 = r26 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM27 = r27 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM28 = r28 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM29 = r29 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM30 = r30 | ZMM << ClassIndex | W512 << WidthIndex,

        ZMM31 = r31 | ZMM << ClassIndex | W512 << WidthIndex,
    }
}