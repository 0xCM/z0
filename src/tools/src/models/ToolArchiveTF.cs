//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly struct ToolArchive<T,F> : IToolArchive<T,F>
        where T : struct, ITool<T>
        where F : unmanaged, Enum
    {
        public ToolId Id {get;}

        public FolderPath Root {get;}
         
        public IExtensionMap<F> Map {get;}

        readonly F[] Flags;
           
        public ToolArchive(ToolId id, FolderPath root)
        {
            Id = id;                                    
            Root = root;            
            Map = new ExtensionMap<F>(0);
            Flags = Enums.literals<F>();
            foreach(var f in Flags)
                MapExtension(f, FileExtension.Define(f.ToString()));
        }      

        public ToolArchive(ToolId id, FolderPath root, IExtensionMap<F> map)
        {
            Id = id;                                    
            Root = root;            
            Map = map;
            Flags = Enums.literals<F>();
        }      

        public void MapExtension(F flag, FileExtension ext)
            => ToolArchive.map(this, flag, ext);

        public FolderPath Dir(F f)
            => ToolArchive.dir(this, f);

        public FolderName Folder(F f)
            => ToolArchive.folder(this, f);

        public FileExtension Ext(F f)
            => ToolArchive.ext(this, f);

        public ToolFiles<T,F> Files(F f)
            => ToolArchive.files(this, f);
    }
}