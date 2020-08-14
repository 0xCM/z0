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
        [MethodImpl(Inline), Op]
        public static DumpBin create(IWfContext wf, DumpBinFlag flags)
            => new DumpBin(wf, wf.ToolOuputDir(Name), wf.ToolProcessDir(Name), flags);

        public const string Name = "dumpbin";                

        public static ToolId Id => Name;
        
        public IWfContext Wf;

        public ToolId ToolId {get;}

        public string ToolName {get;}
        
        public FolderPath Source {get;}
        
        public IToolArchive<DumpBin> Archive {get;}

        public IExtensionMap<DumpBinFlag> Map {get;}

        public ToolFlags<DumpBinFlag> AvailableFlags {get;}
        
        public DumpBinFlag SelectedFlags {get;}
        
        [MethodImpl(Inline)]
        public DumpBin(IWfContext wf, FolderPath outdir, FolderPath processed, DumpBinFlag selected)
        {
            Wf = wf;
            SelectedFlags = selected;
            ToolName = Name;
            ToolId = ToolName;
            Source = outdir;
            AvailableFlags = new ToolFlags<DumpBinFlag>(0);
            Map = new ExtensionMap<DumpBinFlag,ExtMap>(0);
            Archive = new ToolArchive<DumpBin>(ToolId, outdir, processed);
            Wf.Created(Name);
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
            var listed = Tooling.listed(files);
            return listed;
            //var formatted = FS.format(listed);
            //for(var i=0u; i <files.Count; i++)
            //{
                // if(files[i].Path.Name.Contains(".instructions."))
                // {
                //     Process(files[i]);
                //     var message = text.format(FormatLiterals.PSx2, processor.LineCount, processor.IxCount);
                //     Wf.Status(ActorName, message, Ct);
                // }
            //}                           

        }
        public void Dispose()
        {
            Wf.Finished(Name);
        }
    }
}