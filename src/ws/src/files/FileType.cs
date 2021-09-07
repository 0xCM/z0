//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Blit;

    public readonly struct FileType : IFileType<FileType>
    {
        public FileKind Kind {get;}

        public text15 ExtName {get;}

        [MethodImpl(Inline)]
        public FileType(FileKind kind, text15 ext)
        {
            Kind = kind;
            ExtName = ext;
        }

        [MethodImpl(Inline)]
        public FileType(FileKind kind, FS.FileExt ext)
        {
            Kind = kind;
            ExtName = ext.Format();
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Kind == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Kind != 0;
        }

        public FS.FileExt Ext
            => FS.ext(ExtName.Format());

        public string Format()
            => Kind.Format();

        public override string ToString()
            => Format();

        public static implicit operator FS.FileExt(FileType src)
            => src.Ext;

        public static FileType Empty
        {
            [MethodImpl(Inline)]
            get => new FileType(FileKind.None, text15.Empty);
        }
    }
}