//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CaptureArchives : IPartCaptureArchive
    {        
        [MethodImpl(Inline)]
        public static IPartCaptureArchive create(FolderPath root, FolderName area, FolderName subject)
            => new CaptureArchives(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);        

        public FolderPath ArchiveRoot {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}

        [MethodImpl(Inline)]
        public CaptureArchives(FolderPath root, FolderName area, FolderName subject)
        {
            ArchiveRoot = root.Create();
            AreaName = area;
            SubjectName = subject;
        }
    }
}