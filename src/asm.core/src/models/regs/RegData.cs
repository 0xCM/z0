//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static math;

    using static RegWidthCode;
    using static RegClassCode;
    using static RegIndexCode;
    using static RegFacets;
    using static RegClasses;

    [LiteralProvider]
    public readonly struct RegFacets
    {
        /// <summary>
        /// The RegisterCode segment position
        /// </summary>
        public const byte IndexField = 0;

        /// <summary>
        /// K: The RegisterClass segment position
        /// </summary>
        public const byte ClassField = 5;

        /// <summary>
        /// W: The RegisterWidth segment position
        /// </summary>
        public const byte WidthField = 10;

        /// <summary>
        /// When present, designates the upper half of a given register
        /// </summary>
        public const ushort Hi = 1 << 15;

        public const byte ClassCount = 17;

        public const byte WidthCount = 8;

        public const byte IndexCount = 32;
    }

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RegWidthCode> widths()
            => RegWidthCodes;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RegClassCode> classes()
            => RegClasses;

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RegIndexCode> indices()
            => RegIndexCodes;

        [MethodImpl(Inline), Op]
        public static byte regcount(RegClassCode @class)
            => skip(RegClassCounts, (byte)@class);

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegWidthCode width, RegClassCode @class, RegIndexCode r)
            => new RegOp(or((byte)width, sll((ushort)@class, 5), sll((ushort)r, 10)));

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegKind kind)
            => new RegOp((ushort)kind);

        /// <summary>
        /// Combines a <see cref='RegIndexCode'/>, a <see cref='RegClassCode'/> and a <see cref='RegWidthCode'/> to produce a <see cref='RegKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegKind kind(RegIndexCode i, RegClassCode k, RegWidthCode w)
            => (RegKind)(((uint)i  << IndexField) | ((uint)k << ClassField) | ((uint)w << WidthField));

        [MethodImpl(Inline), Op]
        public static uint regops(RegClassCode @class, RegWidthCode w, Span<RegOp> dst)
        {
            ref var r = ref first(dst);
            var count = regcount(@class);
            var counter = 0u;
            for(var i=0; i<count; i++)
                seek(r,counter++) = reg((RegWidthCode)w, @class, (RegIndexCode)i);
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RegOp> list(GpClass @class)
            => recover<RegOp>(GpRegData);


        [MethodImpl(Inline), Op]
        public static RegIndexCode index(RegOp src)
            =>(RegIndexCode)Bits.segment(src.Bitfield, 10, 15);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndexCode index(RegKind src)
            => (RegIndexCode)Bits.slice((uint)src, (byte)RegFieldIndex.C, (byte)RegFieldWidth.RegCode);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClassCode @class(RegKind src)
            => (RegClassCode)Bits.slice((uint)src, (byte)RegFieldIndex.K, (byte)RegFieldWidth.RegClass);

        /// <summary>
        /// Determines the register class from the operand
        /// </summary>
        /// <param name="src">The register operand</param>
        [MethodImpl(Inline), Op]
        public static RegClassCode @class(RegOp src)
            => (RegClassCode)Bits.segment(src.Bitfield, 5, 9);

        /// <summary>
        /// Determines whether a specified operand references a general-purpose register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit gp(RegOp r)
            => gp(r.RegClass);

        [MethodImpl(Inline), Op]
        public static bit gp(RegClassCode c)
            => c == RegClassCode.GP;

        [MethodImpl(Inline), Op]
        public static bit gp(RegOp r, RegWidthCode w)
            => w == r.Width && gp(r);

        /// <summary>
        /// Determines whether a specified operand references an xmm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit xmm(RegOp r)
            => xmm(r.RegClass);

        /// <summary>
        /// Determines whether a specified class code designates an xmm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit xmm(RegClassCode c)
            => c == RegClassCode.XMM;

        /// <summary>
        /// Determines whether a specified operand references a ymm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit ymm(RegOp r)
            => ymm(r.RegClass);

        /// <summary>
        /// Determines whether a specified class code designates a ymm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit ymm(RegClassCode c)
            => c == RegClassCode.YMM;

        /// <summary>
        /// Determines whether a specified operand references an zmm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit zmm(RegOp r)
            => zmm(r.RegClass);

        /// <summary>
        /// Determines whether a specified class code designates a zmm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit zmm(RegClassCode c)
            => c == RegClassCode.ZMM;

        /// <summary>
        /// Determines the width of a specified operand
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static RegWidthCode width(RegOp src)
            => (RegWidthCode)(src.Bitfield & 0b111);

        /// <summary>
        /// Determines the width of the register represented by a specified kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidthCode width(RegKind src)
            => (RegWidthCode)Bits.slice((uint)src, (byte)RegFieldIndex.W, (byte)RegFieldWidth.RegWidth);

        [MethodImpl(Inline), Op]
        public static bit valid(RegIndexCode src)
            => (uint)src <= 31;

        /// <summary>
        /// Determines whether a specified register index code is within the inclusive range [0,31]
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static bit invalid(RegIndexCode src)
            => (uint)src >= 32;

        [MethodImpl(Inline), Op]
        public static ushort bitwidth(RegWidthCode src)
            => src == RegWidthCode.W80 ? (ushort)80 : (ushort)Pow2.pow((byte)(((byte)src) << 3));

        [MethodImpl(Inline), Op]
        public static void split(RegKind src, out RegIndexCode c, out RegClassCode k, out RegWidthCode w)
        {
            c = index(src);
            k = @class(src);
            w = width(src);
        }

        public enum RegFieldIndex : byte
        {
            /// <summary>
            /// RegisterCode: [0..5]
            /// </summary>
            C = IndexField,

            /// <summary>
            /// RegisterClass:[6..9]
            /// </summary>
            K = ClassField,

            /// <summary>
            /// Register width: [10..13]
            /// </summary>
            W = WidthField,

            /// <summary>
            /// Upper register selection: [15]
            /// </summary>
            H = 15,
        }

        public enum RegFieldWidth : byte
        {
            RegCode = 5,

            RegClass = 4,

            RegWidth = 3,
        }

        internal static ReadOnlySpan<byte> RegClassCounts
            => new byte[ClassCount]{
                0,      // None
                64,     // GP (no hi)
                8,      // MASK
                32,     // XMM
                32,     // YMM
                32,     // ZMM
                8,      // MMX
                6,      // SEG
                3,      // FLAG
                8,      // CR
                1,      // XCR
                8,      // DB
                8,      // ST
                4,      // BND
                3,      // SPTR
                3,      // IPTR
                4       // GP8HI
            };

        static ReadOnlySpan<RegClassCode> RegClasses
            => new RegClassCode[ClassCount]
                {
                    0,
                    GP,
                    MASK,
                    XMM,
                    YMM,
                    ZMM,
                    MMX,
                    SEG,
                    FLAG,
                    CR,
                    XCR,
                    DB,
                    ST,
                    BND,
                    SPTR,
                    IPTR,
                    GP8HI
                };

        static ReadOnlySpan<RegWidthCode> RegWidthCodes
            => new RegWidthCode[WidthCount]
            {
                W8,
                W16,
                W32,
                W64,
                W128,
                W256,
                W512,
                W80,
            };

        static ReadOnlySpan<RegIndexCode> RegIndexCodes
            => new RegIndexCode[IndexCount]
            {
                r0,
                r1,
                r2,
                r3,
                r4,
                r5,
                r6,
                r7,
                r8,
                r9,
                r10,
                r11,
                r12,
                r13,
                r14,
                r15,
                r16,
                r17,
                r18,
                r19,
                r20,
                r21,
                r22,
                r23,
                r24,
                r25,
                r26,
                r27,
                r28,
                r29,
                r30,
                r31
            };

        static ReadOnlySpan<byte> GpRegData
            => new byte[128]{0x23,0x00,0x22,0x00,0x21,0x00,0x20,0x00,0x23,0x04,0x22,0x04,0x21,0x04,0x20,0x04,0x23,0x08,0x22,0x08,0x21,0x08,0x20,0x08,0x23,0x0c,0x22,0x0c,0x21,0x0c,0x20,0x0c,0x23,0x10,0x22,0x10,0x21,0x10,0x20,0x10,0x23,0x14,0x22,0x14,0x21,0x14,0x20,0x14,0x23,0x18,0x22,0x18,0x21,0x18,0x20,0x18,0x23,0x1c,0x22,0x1c,0x21,0x1c,0x20,0x1c,0x23,0x20,0x22,0x20,0x21,0x20,0x20,0x20,0x23,0x24,0x22,0x24,0x21,0x24,0x20,0x24,0x23,0x28,0x22,0x28,0x21,0x28,0x20,0x28,0x23,0x2c,0x22,0x2c,0x21,0x2c,0x20,0x2c,0x23,0x30,0x22,0x30,0x21,0x30,0x20,0x30,0x23,0x34,0x22,0x34,0x21,0x34,0x20,0x34,0x23,0x38,0x22,0x38,0x21,0x38,0x20,0x38,0x23,0x3c,0x22,0x3c,0x21,0x3c,0x20,0x3c};
    }
}