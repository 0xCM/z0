//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    [ApiHost]
    public readonly partial struct Cli
    {
        public static void visualize(FS.FilePath src, FS.FilePath dst)
            => Mdv.run(src.Name,dst.Name);

        public static PdbSymbolStore symbols(IWfRuntime wf)
            => PdbSymbolStore.create(wf);
    }

    [ApiHost]
    public static partial class XCmd
    {

    }
}