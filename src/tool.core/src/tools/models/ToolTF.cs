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
        public const string ActorName = nameof(Tool<T,F>);

        public IWfShell Wf {get;}

        public ToolId ToolId {get;}

        public FolderPath SourceDir {get;}

        public FolderPath Source {get;}

        public IExtensionMap<F> Map {get;}

        public IToolArchive<T> Archive {get;}

        public ToolFlags<F> AvailableFlags {get;}

        [MethodImpl(Inline)]
        public Tool(IWfShell wf, ToolId id, FolderPath src, FolderPath dst)
        {
            Wf = wf;
            ToolId = id;
            SourceDir = src;
            Source = dst;
            AvailableFlags = new ToolFlags<F>(0);
            Map = new ExtensionMap<F>(0);
            Archive = new ToolArchive<T>(id, src,dst);
            Wf.Created(ActorName);
        }


        public void Dispose()
        {
            Wf.Finished(ActorName);
        }
    }
}