//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CmdVarTypes;

    partial struct Cmd
    {
        [MethodImpl(Inline), Op]
        public static CmdScriptVar set(CmdScriptVar src, string value)
            => Cmd.var(src.Symbol, value);

        [MethodImpl(Inline), Op]
        public static DirVar set(DirVar src, FS.FolderPath value)
            => new DirVar(src.Symbol, value);
    }
}