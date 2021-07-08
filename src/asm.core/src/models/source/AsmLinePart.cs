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

    using P = AsmLinePart;

    public enum AsmLinePart : byte
    {
        None = 0,

        // 0005h
        OffsetLabel = 1,

        // mov rax,[rcx]
        Statement = 2,

        // ; ...
        Comment = 4,

        CodeSize = 8,

        // 48 8b 01
        HexCode = 16,

        // MOV r64, r/m64
        Sig = 32,

        // REX.W 8B /r
        OpCode = 64,

        // 0000 1010 ..
        BitCode = 128,
    }

    [ApiHost]
    public readonly struct AsmLineParts
    {
        [Op]
        public static ReadOnlySpan<AsmLinePart> parts(AsmLinePart src)
        {
            var storage = ByteBlock8.Empty;
            var dst = recover<AsmLinePart>(storage.Bytes);
            var i = 0;

            if(OffsetLabel(src))
                seek(dst,i++) = P.OffsetLabel;

            if(Statement(src))
                seek(dst,i++) = P.Statement;

            if(Comment(src))
                seek(dst,i++) = P.Comment;

            if(CodeSize(src))
                seek(dst,i++) = P.CodeSize;

            if(HexCode(src))
                seek(dst,i++) = P.HexCode;

            if(Sig(src))
                seek(dst,i++) = P.Sig;

            if(OpCode(src))
                seek(dst,i++) = P.OpCode;

            if(BitCode(src))
                seek(dst,i++) = P.BitCode;

            return slice(dst,0,i);
        }

        [MethodImpl(Inline), Op]
        public static bit OffsetLabel(AsmLinePart src)
            => (src & AsmLinePart.OffsetLabel) != 0;

        [MethodImpl(Inline), Op]
        public static bit Statement(AsmLinePart src)
            => (src & AsmLinePart.Statement) != 0;

        [MethodImpl(Inline), Op]
        public static bit Comment(AsmLinePart src)
            => (src & AsmLinePart.Comment) != 0;

        [MethodImpl(Inline), Op]
        public static bit CodeSize(AsmLinePart src)
            => (src & AsmLinePart.CodeSize) != 0;

        [MethodImpl(Inline), Op]
        public static bit HexCode(AsmLinePart src)
            => (src & AsmLinePart.HexCode) != 0;

        [MethodImpl(Inline), Op]
        public static bit Sig(AsmLinePart src)
            => (src & AsmLinePart.Sig) != 0;

        [MethodImpl(Inline), Op]
        public static bit OpCode(AsmLinePart src)
            => (src & AsmLinePart.OpCode) != 0;

        [MethodImpl(Inline), Op]
        public static bit BitCode(AsmLinePart src)
            => (src & AsmLinePart.BitCode) != 0;
    }
}