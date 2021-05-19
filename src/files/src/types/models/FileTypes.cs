//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct FileTypeModels
    {
        public readonly struct ExeFileType : IFileType<ExeFileType>
        {
            public FileKind FileKind => FileKind.Exe;

            public Index<FS.FileExt> Extensions => sys.array(FS.Exe);
        }

        public readonly struct DllFileType : IFileType<DllFileType>
        {
            public FileKind FileKind => FileKind.Dll;

            public Index<FS.FileExt> Extensions => sys.array(FS.Dll);
        }

        public readonly struct AsmFileType : IFileType<AsmFileType>
        {
            public FileKind FileKind => FileKind.Asm;

            public Index<FS.FileExt> Extensions => sys.array(FS.Asm);
        }

        public readonly struct BinFileType : IFileType<BinFileType>
        {
            public FileKind FileKind => FileKind.Bin;

            public Index<FS.FileExt> Extensions => sys.array(FS.Bin);
        }

        public readonly struct CsFileType : IFileType<CsFileType>
        {
            public FileKind FileKind => FileKind.Cs;

            public Index<FS.FileExt> Extensions => sys.array(FS.Cs);
        }
    }
}