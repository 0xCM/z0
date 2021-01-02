//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOpCodes
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpression expression(asci32 src)
            => new AsmOpCodeExpression(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpression expression(char[] src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return expression(dst);
        }

        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpression expression(string src)
        {
            var dst = asci32.Null;
            asci.encode(src, out dst);
            return expression(dst);
        }
    }
}