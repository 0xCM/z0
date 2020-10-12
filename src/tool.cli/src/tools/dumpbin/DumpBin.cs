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
        public const string Name = "dumpbin";

        public static ToolSettings settings(FS.FolderPath root)
        {
            var dst = new ToolSettings();
            dst.ToolName = Name;
            dst.InputRoot = root + FS.folder(Name) + FS.folder("input");
            dst.OutputRoot = root + FS.folder(Name) + FS.folder("output");
            dst.ProcessedRoot = root + FS.folder(Name) + FS.folder("processed");
            return dst;
        }

        public static ToolId Id => Name;

        public IWfShell Wf;

        public ToolId ToolId {get;}

        public string ToolName {get;}

        public FS.FolderPath Source {get;}

        public IToolArchive<DumpBin> Archive {get;}

        public IExtensionMap<DumpBinFlag> Map {get;}

        public ToolFlags<DumpBinFlag> AvailableFlags {get;}

        public DumpBinFlag SelectedFlags {get;}

        FS.FolderPath ArchiveRoot
            => FS.dir(@"k:\z0\archives");

        FS.FolderPath ToolOuputDir(string tool)
            => ArchiveRoot + FS.folder("tools") + FS.folder(tool) + FS.folder("output");

        FS.FolderPath ToolProcessDir(string tool)
            => ArchiveRoot + FS.folder("tools") + FS.folder(tool) + FS.folder("processed");

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

        [MethodImpl(Inline)]
        public ProcessRawAsm Processor(DumpBinFlag flags, DumpBinOptions options = default)
            => new ProcessRawAsm(Wf, ToolOuputDir(DumpBin.Name), ToolProcessDir(DumpBin.Name), flags, options);

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