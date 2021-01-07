//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
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
        /// Computes the length, in bytes, of the encoded content
        /// </summary>
        /// <param name="src">The command source</param>
        [MethodImpl(Inline), Op]
        public static byte size(in EncodedInstruction src)
            => src.Size;

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

        [MethodImpl(Inline)]
        static int nlz(ulong src)
            => (int)Lzcnt.X64.LeadingZeroCount(src);

        [MethodImpl(Inline)]
        static int hipos(ulong src)
            => (int)bitwidth<ulong>() - 1 - nlz(src);

        [MethodImpl(Inline)]
        static byte effsize(ulong src)
            => math.sub(math.log2((byte)hipos(src)), One8u);

        [MethodImpl(Inline), Op]
        public static EncodedInstruction encode(ulong src)
            => new EncodedInstruction(src.Bytes());

        /// <summary>
        /// Creates a command from the data supplied in a 64-bit unsigned integer
        /// </summary>
        /// <param name="lo32">The data source</param>
        [MethodImpl(Inline), Op]
        public static EncodedInstruction encode(uint src)
            => new EncodedInstruction(src.Bytes());
    }
}