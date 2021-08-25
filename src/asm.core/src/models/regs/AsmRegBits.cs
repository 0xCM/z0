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
    using static RegFieldFacets;

    [ApiHost]
    public readonly struct AsmRegBits
    {
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

        [MethodImpl(Inline), Op]
        public static RegOp reg(AsmWidthCode width, RegClassCode @class, RegIndexCode r)
            => new RegOp(or((byte)width, sll((ushort)@class, 5), sll((ushort)r, 10)));

        [MethodImpl(Inline), Op]
        public static RegOp reg(RegKind kind)
            => new RegOp((ushort)kind);

        [MethodImpl(Inline), Op]
        public static RegKind kind(RegIndexCode i, RegClassCode k, AsmWidthCode w)
            => (RegKind)(((uint)i  << IndexField) | ((uint)k << ClassField) | ((uint)w << WidthField));

        [MethodImpl(Inline), Op]
        public static uint regops(RegClassCode @class, AsmWidthCode w, Span<RegOp> dst)
        {
            ref var r = ref first(dst);
            var count = AsmRegData.regcount(@class);
            var counter = 0u;
            for(var i=0; i<count; i++)
                seek(r,counter++) = reg((AsmWidthCode)w, @class, (RegIndexCode)i);
            return counter;
        }

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
            => gp(r.RegClassCode);

        [MethodImpl(Inline), Op]
        public static bit gp(RegClassCode c)
            => c == RegClassCode.GP;

        [MethodImpl(Inline), Op]
        public static bit gp(RegOp r, AsmWidthCode w)
            => w == r.WidthCode && gp(r);

        /// <summary>
        /// Determines whether a specified operand references an xmm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit xmm(RegOp r)
            => xmm(r.RegClassCode);

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
            => ymm(r.RegClassCode);

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
            => zmm(r.RegClassCode);

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
        public static AsmWidthCode width(RegOp src)
            => (AsmWidthCode)(src.Bitfield & 0b111);

        /// <summary>
        /// Determines the width of the register represented by a specified kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static AsmWidthCode width(RegKind src)
            => (AsmWidthCode)Bits.slice((uint)src, (byte)RegFieldIndex.W, (byte)RegFieldWidth.RegWidth);

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
        public static ushort bitwidth(AsmWidthCode src)
            => src == AsmWidthCode.W80 ? (ushort)80 : (ushort)Pow2.pow((byte)(((byte)src) << 3));

        [MethodImpl(Inline), Op]
        public static void split(RegKind src, out RegIndexCode c, out RegClassCode k, out AsmWidthCode w)
        {
            c = index(src);
            k = @class(src);
            w = width(src);
        }
    }
}