//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial struct DumpBin : ITool<DumpBin,DumpBinFlag>
    {
        public const string Name = "dumpbin";

        public static WfToolId Id => Name;

        public IWfShell Wf;

        public WfToolId ToolId {get;}

        public string ToolName {get;}

        public FS.FolderPath Source {get;}

        public IToolArchive<DumpBin> Archive {get;}

        public IExtensionMap<DumpBinFlag> Map {get;}

        public ToolFlags<DumpBinFlag> AvailableFlags {get;}

        public DumpBinFlag SelectedFlags {get;}

        [MethodImpl(Inline)]
        public DumpBin(IWfShell wf, FS.FolderPath outdir, FS.FolderPath processed, DumpBinFlag selected)
        {
            Wf = wf;
            SelectedFlags = selected;
            ToolName = Name;
            ToolId = ToolName;
            Source = outdir;
            AvailableFlags = new ToolFlags<DumpBinFlag>(0);
            Map = new ExtensionMap<DumpBinFlag,ExtMap>(0);
            Archive = new ToolArchive<DumpBin>(ToolId, outdir, processed);
            Wf.Created(Id);
        }

        public void Process()
        {
            using var processor = Processor(SelectedFlags);
            processor.Process();
        }

        public ListedFiles List()
        {
            var archive = Archive;
            var root = archive.ToolOutput;
            var files = archive.Dir();
            return Tooling.listed(files);
        }

        public void Dispose()
        {

        }
    }
}