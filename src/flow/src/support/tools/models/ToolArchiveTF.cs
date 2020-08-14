//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly struct ToolArchive<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        public const string ActorName = nameof(ToolArchive<T,F>);
        
        public IWfContext Wf {get;}
        
        public ToolId Id {get;}

        public FolderPath ToolOutput {get;}
         
        public IExtensionMap<F> Map {get;}

        readonly F[] Flags;
           
        public ToolArchive(IWfContext wf, ToolId id, FolderPath root)
        {
            Wf = wf;
            Id = id;                                    
            ToolOutput = root;            
            Map = new ExtensionMap<F>(0);
            Flags = Enums.literals<F>();            
            // foreach(var f in Flags)
            //     MapExtension(f, FileExtension.Define(f.ToString()));
            Wf.Created(ActorName);
        }      

        public ToolArchive(IWfContext wf, ToolId id, FolderPath root, IExtensionMap<F> map)
        {
            Wf = wf;
            Id = id;                                    
            ToolOutput = root;            
            Map = map;
            Flags = Enums.literals<F>();
            Wf.Created(ActorName);
       }      

        // public void MapExtension(F flag, FileExtension ext)
        //     => ToolArchive.map(this, flag, ext);

        // public ToolFiles<T,F> Dir(F f)
        //     => ToolArchive.dir(this, f);

        // public FileExtension Ext(F f)
        //     => ToolArchive.ext(this, f);

        // public ToolFiles<T,F> Files(F f)
        //     => ToolArchive.dir(this, f);
    }
}