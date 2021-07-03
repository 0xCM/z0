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
    using static AsmCodes;

    [ApiHost]
    public readonly struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCode<OffsetToken> cb(byte a0)
            => asm.opcode(a0, OffsetToken.cb);

        [MethodImpl(Inline), Op]
        public static AsmOpCode<OffsetToken> cb(byte a0, byte a1)
            => asm.opcode(uint32(a0) | (uint32(a1) << 8), OffsetToken.cb);

        [MethodImpl(Inline), Op]
        public static AsmOpCode<OffsetToken> cw(byte a0)
            => asm.opcode(a0, OffsetToken.cw);

        [MethodImpl(Inline), Op]
        public static AsmOpCode<OffsetToken> cw(byte a0, byte a1)
            => asm.opcode(uint32(a0) | (uint32(a1) << 8), OffsetToken.cw);

        [MethodImpl(Inline), Op]
        public static AsmOpCode<OffsetToken> cd(byte a0)
            => asm.opcode(a0, OffsetToken.cd);

        [MethodImpl(Inline), Op]
        public static AsmOpCode<OffsetToken> cd(byte a0, byte a1)
            => asm.opcode(uint32(a0) | (uint32(a1) << 8), OffsetToken.cd);

        public static uint render<T>(AsmOpCode<T> src, Span<char> dst)
            where T : unmanaged, Enum
        {
            var data = src.Bytes;
            var i=0u;
            ref readonly var b0 = ref skip(data,0);
            Hex.render(LowerCase, b0, ref i, dst);

            ref readonly var b1 = ref skip(data,1);
            if(b1 !=0)
            {
                seek(dst,i++) = Chars.Space;
                Hex.render(LowerCase, b1, ref i, dst);
            }

            ref readonly var b2 = ref skip(data,2);
            if(b2 != 0)
            {
                seek(dst,i++) = Chars.Space;
                Hex.render(LowerCase, b2, ref i, dst);
            }

            seek(dst,i++) = Chars.Space;
            var symbol = Symbols.index<T>()[src.Kind].Expr.Format();
            SymbolicTools.copy(symbol, ref i, dst);
            return i;
        }

        public static string format<T>(AsmOpCode<T> src)
            where T : unmanaged, Enum
        {
            var storage = CharBlock16.Null;
            var buffer = storage.Data;
            var length = render(src,buffer);
            return text.format(slice(buffer,0,length));
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(EscapePrefix escape, byte a)
            => new AsmOpCode((uint32(a) << 8) | ((uint)escape));

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(EscapePrefix escape, byte a, byte b)
            => new AsmOpCode((uint32(a) << 16) | (uint32(b) << 8) | escape);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(MandatoryPrefix mandatory, EscapePrefix escape, byte a)
            => new AsmOpCode((uint32(a) << 16) | ((uint)escape) << 8 | (uint)mandatory);

        [MethodImpl(Inline), Op]
        public static AsmOpCode opcode(MandatoryPrefix mandatory, EscapePrefix escape, byte a, byte b)
            => new AsmOpCode((uint32(a) << 24) | (uint32(b) << 16) | ((uint)escape) << 8 | (uint)mandatory);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0)
            => spec(b0, 0, 0, OpCodeTokenKind.None);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte a, byte b)
            => spec(a, b, 0, OpCodeTokenKind.None);

        /// <summary>
        /// Example: XOR r/m32, imm8 | 83 /6 ib
        /// Example: AND r/m8,imm8 | 80 /4 ib
        /// </summary>
        /// <param name="b0">The first opcode byte</param>
        /// <param name="ext">The register field digit</param>
        /// <param name="iz">The imm size</param>
        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0, ModRmDigit ext, ImmSize iz)
            => spec(b0, (byte)ext, (byte)iz, OpCodeTokenKind.RexBExtension | OpCodeTokenKind.ImmSize);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0, ImmSize iz)
            => spec(b0,(byte)iz, 0, OpCodeTokenKind.ImmSize);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeSpec spec(byte b0, byte b1, byte b2, OpCodeTokenKind b3)
            => new AsmOpCodeSpec(
                bw32(b0) |
                (bw32(b1) << 8) |
                (bw32(b2) << 16) |
                (bw32(b3) << 24)
                );
    }
}