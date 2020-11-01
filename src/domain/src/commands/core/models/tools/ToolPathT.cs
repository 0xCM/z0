//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolPath<T>
        where T : struct, ITool<T>
    {
        public CmdToolId ToolId {get;}

        public FS.FilePath Source {get;}

        [MethodImpl(Inline)]
        public ToolPath(CmdToolId tool, string src)
        {
            Source = new FS.FilePath(src);
            ToolId = tool;
        }
    }
}
