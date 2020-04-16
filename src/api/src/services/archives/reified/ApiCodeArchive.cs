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

    public readonly struct ApiCodeArchive : IApiCodeArchive
    {
        public static IApiCodeArchive Default => Define(Env.Current.LogDir);

        [MethodImpl(Inline)]
        public static IApiCodeArchive Define(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new ApiCodeArchive(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        ApiCodeArchive(FolderPath root, FolderName area, FolderName subject)
        {
            this.RootDir = reify(root);
            this.AreaName = area;
            this.SubjectName = subject;
        }

        public FolderPath RootDir {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}

        public IApiCodeArchive WithSubject(FolderName area, FolderName subject) => Define(RootDir, area, subject);
    }
}