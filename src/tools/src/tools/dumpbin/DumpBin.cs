//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static DumpBin;

    public partial struct DumpBin : ITool<DumpBin,DumpBinFlag>
    {   
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
            Target = new ToolArchive<DumpBin,DumpBinFlag>(ToolId, TargetDir, Map);
        } 

        public void Dispose()
        {

        }
    }
}