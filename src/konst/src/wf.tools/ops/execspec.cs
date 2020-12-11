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

    partial struct CmdTools
    {
        [MethodImpl(Inline), Op]
        public static CmdExecSpec execspec(FS.FilePath tool, string args, FS.FolderPath? root = null)
            => new CmdExecSpec(tool, args, root);
    }
}