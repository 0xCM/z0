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
        public static OpCodePart part(asci8 src)
            => new OpCodePart(src);

        [MethodImpl(Inline), Op]
        public static OpCodeExpression expression(asci32 src)
            => new OpCodeExpression(src);

        [MethodImpl(Inline), Op]
        public static OpCodeExpression expression(char[] src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return expression(dst);
        }

        [MethodImpl(Inline), Op]
        public static OpCodeExpression expression(string src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return expression(dst);
        }
    }
}