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

    partial struct DumpBin
    {        
        public readonly struct Archive
        {
            public FolderPath Root {get;}        
            
            public FilePath Path(Flag f, FileName file)
                => (Root + Folder(f)) + file;

            public FolderPath Dir(Flag f)
                => Root + Folder(f);
            
            public FolderName Folder(Flag f) 
                => FolderName.Define(f.ToString().ToLower());

            public Archive(FolderPath root)
                => Root = root;     

            public FileExtension Ext(Flag f)   
            {
                switch(f)
                {
                    case Flag.Disasm:
                        return FileExtensions.Asm;
                }

                return FileExtension.Define("doc");
            }
        }
    }
}