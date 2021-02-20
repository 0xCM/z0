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
        [Op]
        public static CmdLine dir(FS.FolderPath src)
        {
            const string Pattern = "cmd /c dir {0}";
            return string.Format(Pattern, src.Format(PathSeparator.BS));
        }

        [Op]
        public static CmdLine script(FS.FilePath src)
        {
            const string Pattern = "cmd /c {0}";
            return string.Format(Pattern, src.Format(PathSeparator.BS));
        }

        public static CmdLine script(string src)
            => script(FS.path(src));

        public static CmdLine dir(string src)
            => dir(FS.dir(src));
    }
}