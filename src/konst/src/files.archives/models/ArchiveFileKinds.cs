//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public readonly struct ArchiveFileKinds
    {
        public readonly struct Pdb : IFileKind<Pdb>
        {
            public FS.FileExt DefaultExt => ArchiveFileExt.Pdb;

            public static implicit operator FS.FileExt(Pdb src)
                => src.DefaultExt;
        }

        public readonly struct Csv : IFileKind<Csv>
        {
            public FS.FileExt DefaultExt => ArchiveFileExt.Csv;

            public static implicit operator FS.FileExt(Csv src)
                => src.DefaultExt;
        }

        public readonly struct Asm : IFileKind<Asm>
        {
            public FS.FileExt DefaultExt => ArchiveFileExt.Asm;

            public static implicit operator FS.FileExt(Asm src)
                => src.DefaultExt;
        }

        public readonly struct Dll : IFileKind<Dll>
        {
            public FS.FileExt DefaultExt => ArchiveFileExt.Dll;

            public static implicit operator FS.FileExt(Dll src)
                => src.DefaultExt;
        }

        public readonly struct Sln : IFileKind<Sln>
        {
            public FS.FileExt DefaultExt => ArchiveFileExt.Sln;

            public static implicit operator FS.FileExt(Sln src)
                => src.DefaultExt;
        }
    }
}