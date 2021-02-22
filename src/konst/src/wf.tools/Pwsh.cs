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
    public readonly struct Pwsh
    {
        [Op]
        public static CmdLine script(FS.FilePath src)
        {
            const string Pattern = "pwsh {0}";
            return string.Format(Pattern, src.Format(PathSeparator.BS));
        }
    }
}
