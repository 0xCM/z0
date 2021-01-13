//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static RexPrefixBits rex(byte src)
            => RexPrefixBits.define(src);

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
    }
}