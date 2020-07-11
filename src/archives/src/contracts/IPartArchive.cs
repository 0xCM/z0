//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public readonly struct PartFileArchive
    {
        readonly TPartCaptureArchive Archive; 

        public PartFileArchive(FolderPath root)
        {
            Archive =  Archives.Services.CaptureArchive(root, null, null);
        }
        
        public FilePath[] ParseFiles
            => Archive.ParseFiles.Array();

        public FilePath[] AsmFiles
            => Archive.AsmFiles.Array();

        public FilePath[] HexFiles
            => Archive.HexFiles.Array();
       
    }
}