//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    [ApiHost]
    public readonly struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCodePart part(asci8 src)
            => new AsmOpCodePart(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCode from(asci32 src)
            => new AsmOpCode(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCode from(char[] src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return from(dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCode from(string src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return from(dst);
        }
    }
}