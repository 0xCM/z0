//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static FileSystem;

    public readonly struct CaptureArchive : ICaptureArchive
    {        
        public FolderPath RootDir {get;}

        public FolderName AreaName {get;}

        public FolderName SubjectName {get;}

        [MethodImpl(Inline)]
        internal CaptureArchive(FolderPath root, FolderName area, FolderName subject)
        {
            this.RootDir = reify(root);
            this.AreaName = area;
            this.SubjectName = subject;
        }

        public ICaptureArchive Narrow(FolderName area, FolderName subject) => new CaptureArchive(RootDir, area, subject);

        ICaptureArchive Me => this;
        
        public FolderPath[] Clear()
        {
            var dst = list<FolderPath>();
            dst.Add(Me.ExtractDir.Clear());
            dst.Add(Me.ParsedDir.Clear());
            dst.Add(Me.AsmDir.Clear());
            dst.Add(Me.HexDir.Clear());
            return dst.ToArray();
        }        
    }
}