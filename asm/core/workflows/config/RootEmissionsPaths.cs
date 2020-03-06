//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct RootEmissionPaths
    {
        [MethodImpl(Inline)]
        public static RootEmissionPaths Define(FolderPath root)
            => new RootEmissionPaths(root);
        
        [MethodImpl(Inline)]
        RootEmissionPaths(FolderPath root)
        {
            this.RootDir = root;
        }

        public readonly FolderPath RootDir;

        public FolderName ExtractFolder 
            => FolderName.Define("extracted");
        
        public FolderPath ExtractDir
            => RootDir + ExtractFolder;

        public FolderName ParsedFolder 
            => FolderName.Define("parsed");
        
        public FolderPath ParsedDir
            => RootDir + ParsedFolder;

        public FolderName DecodedFolder 
            => FolderName.Define("decoded");
        
        public FolderPath DecodedDir
            => RootDir + DecodedFolder;

        public FolderName AssemblyFolder(AssemblyId id) 
            => FolderName.Define(id.Format());

        public FolderPath AssemblyDir(AssemblyId id)
            => RootDir + AssemblyFolder(id);


        public RootEmissionPaths Clear()
        {
            ExtractDir.Clear();
            ParsedDir.Clear();
            DecodedDir.Clear();
            return this;
        }            
    }
}