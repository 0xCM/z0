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

    [ApiHost]
    public readonly partial struct AsmLayouts
    {
        [MethodImpl(Inline), Op]
        public static Layout1 layout(Hex8 src)
        {
            var dst = new Layout1();
            dst.OpCode = src;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout2 layout(Hex8 opcode, ModRm mrm)
        {
            var dst = new Layout2();
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout7 layout(Hex8 opcode, Disp8 disp)
        {
            var dst = new Layout7();
            dst.OpCode = opcode;
            dst.Disp = disp;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout8 layout(Hex8 opcode, Disp32 disp)
        {
            var dst = new Layout8();
            dst.OpCode = opcode;
            dst.Disp = disp;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout3 layout(RexPrefix rex, Hex8 opcode, ModRm mrm)
        {
            var dst = new Layout3();
            dst.Rex = rex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout4 layout(LegacyPrefix lp, RexPrefix rex, Hex8 opcode, ModRm mrm)
        {
            var dst = new Layout4();
            dst.Lp = lp;
            dst.Rex = rex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout5 layout(LegacyPrefix lp, RexPrefix rex, Hex8 opcode, ModRm mrm, Sib sib)
        {
            var dst = new Layout5();
            dst.Lp = lp;
            dst.Rex = rex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            dst.Sib = sib;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout9 layout(VexPrefix vex, Hex8 opcode, ModRm mrm)
        {
            var dst = new Layout9();
            dst.Vex = vex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static Layout6 layout(VexPrefix vex, Hex8 opcode, ModRm mrm, Sib sib)
        {
            var dst = new Layout6();
            dst.Vex = vex;
            dst.OpCode = opcode;
            dst.ModRm = mrm;
            dst.Sib = sib;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static LayoutSpec specify(params Slot[] slots)
        {
            var count = slots.Length;
            var storage = Cells.alloc(w128);
            var buffer = storage.Bytes;
            seek(buffer, LayoutSpec.MaxSlotCount) = (byte)count;
            var dst = recover<Slot>(buffer);
            var src = @readonly(slots);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            return new LayoutSpec(storage);
        }
    }
}