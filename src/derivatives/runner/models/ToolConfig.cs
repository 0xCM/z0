//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolConfig
    {
        public FS.FilePath Path;

        [MethodImpl(Inline)]
        public ToolConfig(FS.FilePath path)
        {
            Path = path;
        }
    }

    public struct ToolConfigs
    {


    }
}