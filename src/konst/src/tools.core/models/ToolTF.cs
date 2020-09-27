//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Tool<T,F> : ITool<T,F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        public IWfShell Wf {get;}

        public ToolId ToolId {get;}

        public FS.FolderPath SourceDir {get;}

        public FS.FolderPath Source {get;}

        public IExtensionMap<F> Map {get;}

        public IToolArchive<T> Archive {get;}

        public ToolFlags<F> AvailableFlags {get;}

        [MethodImpl(Inline)]
        public Tool(IWfShell wf, ToolId id, FS.FolderPath src, FS.FolderPath dst)
        {
            Wf = wf;
            ToolId = id;
            SourceDir = src;
            Source = dst;
            AvailableFlags = new ToolFlags<F>(0);
            Map = new ExtensionMap<F>(0);
            Archive = new ToolArchive<T>(id, src,dst);
            Wf.Created(ToolId);
        }

        public void Dispose()
        {

        }
    }
}