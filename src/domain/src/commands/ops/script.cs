//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdScript script(uint count)
            => new CmdScript(alloc<CmdExpr>(count));

        [MethodImpl(Inline), Op]
        public static CmdScript script(params CmdExpr[] expr)
            => new CmdScript(expr);
    }
}