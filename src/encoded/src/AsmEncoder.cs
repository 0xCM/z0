//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;         

    [ApiHost]
    public readonly partial struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static RexPrefixBits rex(byte src)
            => RexPrefixBits.define(src);

        [Op]
        public static string format(RegisterBits src)
        {
            const string Sep = " | ";
            var seg0 = BitFields.format<RegisterCode,byte>(src.Code);
            var seg1 = BitFields.format<RegisterClass,byte>(src.Class);
            var seg2 = BitFields.format<RegisterWidth,ushort>(src.Width);
            var dst = text.bracket(text.concat(seg2, Sep, seg1, Sep, seg0));
            return dst;
        }
    }
}