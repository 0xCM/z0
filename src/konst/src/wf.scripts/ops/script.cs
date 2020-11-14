//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct CmdScripts
    {
        [MethodImpl(Inline), Op]
        public static CmdScript script(utf8 id, CmdExpr[] expr)
            => new CmdScript(id, expr);
    }
}