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

    public readonly struct ToolPaths
    {
        readonly TableSpan<ToolId> Tools;

        readonly TableSpan<FS.FilePath> Paths;

        [MethodImpl(Inline)]
        public ToolPaths(ToolId[] tools, FS.FilePath[] paths)
        {
            Tools = tools;
            Paths = paths;
            Count = (uint)tools.Length;
        }

        public uint Count {get;}
    }
}