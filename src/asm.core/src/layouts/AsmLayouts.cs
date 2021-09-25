//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;
    using static AsmLayoutModels;

    [ApiHost]
    public readonly partial struct AsmLayouts
    {
        [Op]
        public static uint render(in LayoutCore src, Span<char> dst)
        {
            var i=0u;
            seek(dst, i++) = Chars.LBracket;
            AsmBits.rex(src.Rex, ref i, dst);
            seek(dst, i++) = Chars.Space;
            seek(dst, i++) = Chars.Pipe;
            seek(dst, i++) = Chars.Space;
            AsmBits.opcode(src.OpCode, ref i, dst);
            seek(dst, i++) = Chars.Space;
            seek(dst, i++) = Chars.Pipe;
            seek(dst, i++) = Chars.Space;
            AsmBits.modrm(src.ModRm, ref i, dst);
            seek(dst, i++) = Chars.Space;
            seek(dst, i++) = Chars.Pipe;
            seek(dst, i++) = Chars.Space;
            AsmBits.sib(src.Sib, ref i, dst);
            seek(dst,i++) = Chars.RBracket;
            return i;
        }

        [MethodImpl(Inline), Op]
        public static LayoutCore define(RexPrefix rex, Hex8 opcode, ModRm mrm, Sib sib)
        {
            var dst = new LayoutCore();
            dst.Rex = rex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            dst.Sib = sib;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout1 define(Hex8 src)
        {
            var dst = new Layout1();
            dst.OpCode = src;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout2 define(Hex8 opcode, ModRm mrm)
        {
            var dst = new Layout2();
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout7 define(Hex8 opcode, Disp8 disp)
        {
            var dst = new Layout7();
            dst.OpCode = opcode;
            dst.Disp = disp;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout8 define(Hex8 opcode, Disp32 disp)
        {
            var dst = new Layout8();
            dst.OpCode = opcode;
            dst.Disp = disp;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout3 define(RexPrefix rex, Hex8 opcode, ModRm mrm)
        {
            var dst = new Layout3();
            dst.Rex = rex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout9 define(VexPrefix vex, Hex8 opcode, ModRm mrm)
        {
            var dst = new Layout9();
            dst.Vex = vex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout6 define(VexPrefix vex, Hex8 opcode, ModRm mrm, Sib sib)
        {
            var dst = new Layout6();
            dst.Vex = vex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            dst.Sib = sib;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmLayoutSpec specify(params AsmLayoutSlot[] slots)
        {
            var count = slots.Length;
            var storage = Cells.alloc(w128);
            var buffer = storage.Bytes;
            seek(buffer, AsmLayoutSpec.MaxSlotCount) = (byte)count;
            var dst = recover<AsmLayoutSlot>(buffer);
            var src = @readonly(slots);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            return new AsmLayoutSpec(storage);
        }
    }
}