//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolConfig<T> : IToolConfig<T>
        where T : struct, ITool<T>
    {
        public WfToolId ToolId {get;}

        public FolderPath Source {get;}

        public FolderPath Target {get;}

        [MethodImpl(Inline)]
        public ToolConfig(WfToolId tool, FolderPath src, FolderPath dst)
        {
            Source = src;
            ToolId = tool;
            Target = dst;
        }
    }
}
