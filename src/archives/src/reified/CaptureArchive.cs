//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static FileSystem;

    public readonly struct CaptureArchive : ICaptureArchive
    {        
        public FolderPath RootDir {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}

        [MethodImpl(Inline)]
        internal CaptureArchive(FolderPath root, FolderName area, FolderName subject)
        {
            RootDir = reify(root);
            AreaName = area;
            SubjectName = subject;
        }
    }
}