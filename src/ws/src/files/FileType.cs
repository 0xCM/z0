//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = FileTypes;

    public readonly struct FileType : IFileType<FileType>
    {
        public FileKind Kind {get;}

        [MethodImpl(Inline)]
        public FileType(FileKind kind)
        {
            Kind = kind;
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
            => api.ext(Kind);

        public string Format()
            => api.format(Kind);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator FS.FileExt(FileType src)
            => src.Ext;

        [MethodImpl(Inline)]
        public static implicit operator FileType(FileKind src)
            => new FileType(src);

        public static FileType Empty
        {
            [MethodImpl(Inline)]
            get => new FileType(FileKind.None);
        }
    }
}