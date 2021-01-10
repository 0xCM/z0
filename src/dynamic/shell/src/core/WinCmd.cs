//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct WinCmd
    {
        [MethodImpl(Inline), Op]
        public static CmdLine dir(FS.FolderPath src)
        {
            const string Pattern = "cmd /c dir {0}";
            return string.Format(Pattern, src.Format(PathSeparator.BS));
        }
    }
}