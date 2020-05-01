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

        ICaptureArchive Archive => this;
        
        public FolderPath[] Clear(params PartId[] parts)
        {
            if(parts.Length == 0)
            {
                var dst = list<FolderPath>();
                dst.Add(Archive.ExtractDir.Clear());
                dst.Add(Archive.ParsedDir.Clear());
                dst.Add(Archive.AsmDir.Clear());
                dst.Add(Archive.HexDir.Clear());
                dst.Add(Archive.UnparsedDir.Clear());
                return dst.ToArray();
            }
            else
            {
                for(var i=0; i<parts.Length; i++)
                {
                    var part = parts[i];
                    Control.iter(Archive.ExtractDir.Files(part, Archive.ExtractExt), f => f.Delete());
                    Control.iter(Archive.ParsedDir.Files(part, Archive.ParsedExt), f => f.Delete());
                    Control.iter(Archive.AsmDir.Files(part, Archive.AsmExt), f => f.Delete());
                    Control.iter(Archive.HexDir.Files(part, Archive.HexExt), f => f.Delete());
                    Control.iter(Archive.UnparsedDir.Files(part, Archive.UnparsedExt), f => f.Delete());
                }
                return Control.array<FolderPath>();
            }
        }        
    }
}