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
        public static ICaptureArchive Default => Define(Env.Current.LogDir);

        [MethodImpl(Inline)]
        public static ICaptureArchive Define(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchive(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        CaptureArchive(FolderPath root, FolderName area, FolderName subject)
        {
            this.RootDir = reify(root);
            this.AreaName = area;
            this.SubjectName = subject;
        }

        public FolderPath RootDir {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}

        public ICaptureArchive WithSubject(FolderName area, FolderName subject) => Define(RootDir, area, subject);

        ICaptureArchive Me => this;
        
        public ICaptureArchive Clear()
        {
            Me.ExtractDir.Clear();
            Me.ParsedDir.Clear();
            Me.AsmDir.Clear();
            Me.HexDir.Clear();
            return this;
        }        
    }
}