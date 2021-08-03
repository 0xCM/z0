//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static Root;
    using static core;
    using static AsmCodes;

    using K = AsmCodes.RexPrefixCode;

    [ApiHost]
    public readonly partial struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static MandatoryPrefix mandatory(MandatoryPrefixCode code)
            => new MandatoryPrefix(code);

        [MethodImpl(Inline), Op]
        public static Vsib vsib(byte src)
            => new Vsib(src);

        [MethodImpl(Inline), Op]
        public static BndPrefix bnd()
            => BndPrefixCode.BND;

        [MethodImpl(Inline), Op]
        public static AsmPrefix prefix()
            => new AsmPrefix(0);

        [MethodImpl(Inline), Op]
        public static BranchHint hint(bit bt)
            => bt ? BranchHintCode.BT : BranchHintCode.BNT;

        [MethodImpl(Inline), Op]
        public static SizeOverrides sizes(bit opsz, bit adsz)
            => new SizeOverrides(opsz,adsz);

        [MethodImpl(Inline), Op]
        public static bit test(K src, K match)
            => (src & match) == match;

        [MethodImpl(Inline), Op]
        public static ref AsmHexCode encode(RexPrefix a0, ref AsmHexCode dst)
        {
            var writer = write(dst.Bytes);
            writer.Write8(a0);
            dst = close(writer, dst.Bytes);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(RexPrefix a0, Hex8 a1, Imm64 a2)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            writer.Write64(a2);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static AsmHexCode encode(Hex8 a0, Imm8 a1)
        {
            var writer = write(buffer());
            writer.Write8(a0);
            writer.Write8(a1);
            return load(writer);
        }

        [MethodImpl(Inline), Op]
        public static byte encode(Hex8 a0, Imm8 a1, ref byte hex)
        {
            seek(hex,0) = a0;
            seek(hex,1) = a1;
            return 2;
        }

        [MethodImpl(Inline), Op]
        static Span<byte> buffer()
            => ByteBlocks.alloc(n16).Bytes;

        [MethodImpl(Inline)]
        static SpanWriter write(Span<byte> dst)
            => Spans.writer(dst);

        [MethodImpl(Inline), Op]
        static AsmHexCode close(in SpanWriter writer, Span<byte> dst)
        {
            seek(dst, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(first(recover<Cell128>(dst)));
        }

        [MethodImpl(Inline)]
        static unsafe Vector128<byte> vload(Span<byte> src)
            => LoadDquVector128(gptr(first(src)));

        [MethodImpl(Inline), Op]
        static AsmHexCode load(SpanWriter writer)
        {
            seek(writer.Target, AsmHexCode.SizeIndex) = (byte)writer.BytesWritten;
            return new AsmHexCode(vload(writer.Target));
        }
    }
}