//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct ToolTarget<T> : IToolTarget<T>
        where T : struct, ITool<T>
    {
        public ToolId ToolId => Tooling.toolid<T>();

        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public ToolTarget(FS.FilePath path)
        {
            Path = Files.normalize(path);
        }
    }
}