//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static RexPrefixBits rex(byte src)
            => RexPrefixBits.define(src);

        /// <summary>
        /// Presents encoded content as a bytespan of variable length from 0 to 15 bytes
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> bytes(in EncodedInstruction src)
            => Cells.view<byte>(Cells.from(src.Data)).Slice(size(src));

        /// <summary>
        /// Computes the length, in bytes, of the encoded content
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static byte size(in EncodedInstruction src)
            => vcell(src.Data, 15);

        [Op]
        public static string format(in EncodedInstruction src)
        {
            var data = AsmEncoder.bytes(src);
            var size = src.EncodingSize;
            return text.concat($"data", text.bracket(size), Chars.Colon, text.embrace(data.FormatHex()));
        }

        [Op]
        public static string format(in ModRmEncoding src)
        {
            const string Sep = " | ";
            const string Assign = " = ";

            var a = src.Rm.Format();
            var b = src.Reg.Format();
            var c = src.Mod.Format();
            var e = src.Encoded.Format();
            return text.concat(a, Sep, b, Sep, c, Assign, e);
        }

        /// <summary>
        /// Defines a command from data supplied by a bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedInstruction encode(ReadOnlySpan<byte> src)
        {
            var dst = default(Vector128<byte>);
            var count = src.Length;
            var max = min(15,count);
            for(var i=0; i<max; i++)
                dst = dst.WithElement(i, skip(src,i));
            var c = new EncodedInstruction(dst.WithElement(15, (byte)count));
            var b = bytes(c);
            return c;
        }

        [MethodImpl(Inline)]
        static int nlz(ulong src)
            => (int)Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        static int hipos(ulong src)
            => (int)bitwidth<ulong>() - 1 - nlz(src);

        [MethodImpl(Inline)]
        static byte effsize(ulong src)
            => math.sub(math.log2((byte)hipos(src)), One8u);

        /// <summary>
        /// Creates a command from data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo64">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedInstruction encode(ulong lo64)
        {
            var hi64 = (ulong)(effsize(lo64)/8) << 56;
            var v = v8u(Vector128.Create(lo64, hi64));
            return new EncodedInstruction(v);
        }

        /// <summary>
        /// Creates a command from the data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo32">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedInstruction encode(uint lo32)
            => encode((ulong)lo32);
    }
}