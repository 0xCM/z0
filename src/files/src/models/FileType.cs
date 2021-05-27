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

    public readonly struct FileType : IFileType
    {
        public Type Rep {get;}

        public FileKind FileKind {get;}

        public FS.FileExt FileExt {get;}

        [MethodImpl(Inline)]
        public FileType(Type rtt, FileKind kind, FS.FileExt ext)
        {
            Rep = rtt;
            FileKind = kind;
            FileExt = ext;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => FileExt.IsEmpty || FileKind == 0;
        }

        public string Description
        {
            get => api.describe(this);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => FileExt.IsNonEmpty && FileKind != 0;
        }

        public string Format()
            => FileKind.Format();

        public override string ToString()
            => Format();

        public static FileType Empty
        {
            [MethodImpl(Inline)]
            get => new FileType(typeof(void), FileKind.None, FS.FileExt.Empty);
        }

        public string Wildcard()
            => api.wildcard(this);
    }
}