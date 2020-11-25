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
    using static CmdVarTypes;

    partial struct WfScripts
    {
        [MethodImpl(Inline), Op]
        public static CmdScriptVar set(CmdScriptVar src, string value)
            => var(src.Symbol, value);

        [MethodImpl(Inline), Op]
        public static DirVar set(DirVar src, FS.FolderPath value)
            => dir(src.Symbol, value);
    }
}