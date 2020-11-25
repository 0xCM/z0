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

    partial struct WfScripts
    {
        [MethodImpl(Inline), Op]
        public static CmdScript script(string id, CmdScriptExpr[] expr)
            => new CmdScript(id, expr);
    }
}