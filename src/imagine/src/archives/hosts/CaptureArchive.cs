//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CaptureArchiveService : TPartCaptureArchive
    {        
        public static TPartCaptureArchive create(FolderPath root, FolderName area, FolderName subject)
            => new CaptureArchiveService(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);        

        public FolderPath ArchiveRoot {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}

        [MethodImpl(Inline)]
        internal CaptureArchiveService(FolderPath root, FolderName area, FolderName subject)
        {
            ArchiveRoot = root.Create();
            AreaName = area;
            SubjectName = subject;
        }
    }
}