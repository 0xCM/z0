//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial struct DumpBin : ITool<DumpBin,DumpBinFlag>
    {
        [MethodImpl(Inline)]
        public ProcessRawAsm Processor(DumpBinFlag flags, DumpBinOptions options = default)
            => new ProcessRawAsm(Wf, Wf.ToolOuputDir(DumpBin.Name), Wf.ToolProcessDir(DumpBin.Name), flags, options);

        public const string Name = "dumpbin";

        public static ToolId Id => Name;

        public IWfShell Wf;

        public ToolId ToolId {get;}

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
            return Tools.list(files);
        }

        public void Dispose()
        {

        }
    }
}