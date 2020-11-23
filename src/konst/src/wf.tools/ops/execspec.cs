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

    partial struct Tooling
    {
        [MethodImpl(Inline), Op]
        public static ToolExecSpec execspec(FS.FilePath tool, string args, FS.FolderPath? root = null)
            => new ToolExecSpec(tool, args, root);
    }
}