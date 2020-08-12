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
        public static DumpBin create(IWfContext wf)
            => new DumpBin(wf, Tooling.ToolSourceDir, (wf.AppPaths.LogRoot + FolderName.Define("tools")) + FolderName.Define(DumpBin.ToolName));

        public const string ToolName = "dumpbin";
        
        public const ToolId Identity = ToolId.Dumpbin;
        
        public IWfContext Wf;

        public ToolId ToolId {get;}

        public string Name {get;}

        public FolderPath SourceDir {get;}
        
        public FolderPath TargetDir {get;}
        
        public IToolArchive<DumpBin,DumpBinFlag> Target {get;}

        public IExtensionMap<DumpBinFlag> Map {get;}

        public ToolFlags<DumpBinFlag> Flags {get;}
        
        [MethodImpl(Inline)]
        public DumpBin(IWfContext wf, FolderPath src, FolderPath dst)
        {
            Wf = wf;
            ToolId = Identity;
            Name = ToolName;
            SourceDir = src;
            TargetDir = dst;
            Flags = new ToolFlags<DumpBinFlag>(0);
            Map = new ExtensionMap<DumpBinFlag,ExtMap>(0);
            Target = new ToolArchive<DumpBin,DumpBinFlag>(wf, ToolId, TargetDir, Map);
            Wf.Created(ToolName);
        } 

        public void Dispose()
        {
            Wf.Finished(ToolName);
        }
    }
}