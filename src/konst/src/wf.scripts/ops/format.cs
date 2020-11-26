//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static z;
    using static Konst;
    using static CmdVarTypes;

    partial struct WfScripts
    {
        [Op]
        public static string format(CmdScriptVar src)
            => string.Format("{0}={1}",src.Symbol, src.Value);
    }
}