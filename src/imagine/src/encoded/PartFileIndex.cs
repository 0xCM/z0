//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct PartFileIndex : IPartFileIndex
    {   
        public static IPartFileIndex create(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new PartFileIndex(new CaptureArchiveService(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty));        

        readonly TPartCaptureArchive CaptureArchive;                 

        [MethodImpl(Inline)]
        internal PartFileIndex(TPartCaptureArchive capture)
        {
            CaptureArchive = capture;
        } 

        public FilePath[] ExtractFiles
            => CaptureArchive.ExtractFiles;

        public FilePath[] ParseFiles 
            => CaptureArchive.ParseFiles;

        public FilePath[] ParseFileFilter(params PartId[] parts)
            => CaptureArchive.ParseFilePaths(parts);

        public FilePath[] AsmFilePaths(params PartId[] parts)
            => CaptureArchive.AsmFilePaths(parts);

        public FilePath[] HexFilePaths(params PartId[] parts)
            => CaptureArchive.HexFilePaths(parts);

        public FilePath[] AsmFiles 
            => CaptureArchive.AsmFiles;

        public FilePath[] HexFiles
            => CaptureArchive.HexFiles;
    }    
}