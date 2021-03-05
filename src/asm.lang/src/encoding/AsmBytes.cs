//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using RFI = RexFieldIndex;
    using RF = RexFieldIndex;

    [ApiHost]
    public readonly partial struct AsmBytes
    {
        [MethodImpl(Inline), Op]
        public static bit isrex(AsmByte src)
            => (src & 0x40) != 0;

        [Op]
        public static string format(AsmHexCode src)
            => src.Data.FormatHexData(src.Size);

        [MethodImpl(Inline), Op]
        public static AsmHexCode hexcode(ReadOnlySpan<byte> src)
        {
            var cell = Cells.alloc(w128);
            var count = (byte)root.min(src.Length, 15);
            var dst = bytes(cell);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            Cells.cell8(cell, 15) = count;
            return new AsmHexCode(cell);
        }

        [Op]
        public static AsmHexCode hexcode(string src)
        {
            var dst = AsmHexCode.Empty;
            hexcode(src, out dst);
            return dst;
        }

        [Op]
        public static bool hexcode(string src, out AsmHexCode dst)
        {
            var parser = HexByteParser.Service;
            if(parser.Parse(src, out var data))
            {
                dst = data;
                return true;
            }
            else
            {
                dst = AsmHexCode.Empty;
                return false;
            }
        }

        [MethodImpl(Inline), Op]
        public static RexBits next(RexBits src)
        {
            if(src.Data < RexBits.MaxRexCode)
                return new RexBits(++src.Data);
            else
                return new RexBits(RexBits.MinRexCode);
        }

        [MethodImpl(Inline), Op]
        public static RexBits prior(RexBits src)
        {
            if(src.Data > RexBits.MinRexCode)
                return new RexBits(--src.Data);
            else
                return new RexBits(RexBits.MaxRexCode);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<RexBits> rexbits()
            => recover<RexBits>(RexBits.All);

        static string hex(RexBits src)
            => src.Data.FormatAsmHex();

        static Identifier symbol(RexBits src)
        {
            if(src.Code == RexPrefixCode.RexW)
                return "REX.W";
            else
                return "";
        }

        [Op]
        static string bits(RexBits src)
        {
            var bs = src.Data.FormatBits();
            var chars = text.span(bs);
            var lo = slice(chars,0,4);
            var hi = slice(chars,4,4);
            return text.format("[{0} {1}]", lo, hi);
        }

        [Op]
        public static string format(RexBits src)
            => $"{hex(src)} | {bits(src)} | {RF.W}:{src.W} | {RF.R}:{src.R} | {RF.X}:{src.X} | {RF.B}:{src.B} | {symbol(src)}";

        [MethodImpl(Inline), Op]
        public static ModRmBits modrm(byte src)
            => new ModRmBits(src);

        [MethodImpl(Inline), Op]
        public static ModRmBits modrm(uint3 rm, uint3 reg, uint2 mod)
            => new ModRmBits(rm, reg, mod);

        [MethodImpl(Inline), Op]
        public static ModRmBits define(uint3 rm, uint3 reg, uint2 mod)
            => new ModRmBits(rm,reg,mod);

        [Op]
        public static uint fill(Span<ModRmBits> dst)
        {
            var rmF = BitSeq.bits(w3);
            var regF = BitSeq.bits(w3);
            var modF = BitSeq.bits(w2);

            var i = 0u;
            for(var a=0u; a<rmF.Length; a++)
            for(var b=0u; b<regF.Length; b++)
            for(var c=0u; c<modF.Length; c++, i++)
            {
                ref readonly var rm = ref skip(rmF, a);
                ref readonly var reg = ref skip(regF, b);
                ref readonly var mod = ref skip(modF, c);
                seek(dst, i) = define(rm, reg, mod);
            }
            return i;
        }

        public static Index<ModRmBits> modrm()
        {
            var dst = sys.alloc<ModRmBits>(256);
            fill(dst);
            return dst;
        }

    }
}