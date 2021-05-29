//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost]
    public readonly struct PwshCmd
    {
        [Op]
        public static CmdLine script(FS.FilePath src)
        {
            const string Pattern = "pwsh {0}";
            return string.Format(Pattern, src.Format(PathSeparator.BS));
        }
    }
}
