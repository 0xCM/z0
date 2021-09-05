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

    public readonly struct FileType
    {
        public FileKind FileKind {get;}

        public text15 ExtName {get;}

        [MethodImpl(Inline)]
        public FileType(FileKind kind, text15 ext)
        {
            FileKind = kind;
            ExtName = ext;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => FileKind == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => FileKind != 0;
        }

        public FS.FileExt Ext
            => FS.ext(ExtName.Format());

        public string Format()
            => FileKind.Format();

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