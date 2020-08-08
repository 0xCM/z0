//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static DumpBin;

    public partial struct DumpBin : ITool<DumpBin,Flag>
    {   
        public const string ToolName = "dumpbin";
        
        public const ToolId Identity = ToolId.Dumpbin;
        
        public IWfContext Wf;

        public ToolId ToolId {get;}

        public string Name {get;}

        public FolderPath SourceDir {get;}
        
        public FolderPath TargetDir {get;}
        
        public IToolArchive<DumpBin,Flag> Target {get;}

        public IExtensionMap<Flag> Map {get;}

        public ToolFlags<Flag> Flags {get;}
        
        [MethodImpl(Inline)]
        public DumpBin(IWfContext wf, FolderPath src, FolderPath dst)
        {
            Wf = wf;
            ToolId = Identity;
            Name = ToolName;
            SourceDir = src;
            TargetDir = dst;
            Flags = new ToolFlags<Flag>(0);
            Map = new ExtensionMap<Flag,ExtMap>(0);
            Target = new ToolArchive<DumpBin,Flag>(ToolId, TargetDir, Map);
        } 

        public void Dispose()
        {

        }
    }
}