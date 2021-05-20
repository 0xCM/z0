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

        public Index<FS.FileExt> Extensions {get;}

        [MethodImpl(Inline)]
        public FileType(Type rtt, FileKind kind, Index<FS.FileExt> extensions)
        {
            Rep = rtt;
            FileKind = kind;
            Extensions = extensions;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Extensions.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Extensions.IsNonEmpty;
        }

        public FS.FileExt FileExt
        {
            [MethodImpl(Inline)]
            get => IsNonEmpty ? Extensions.First : FS.FileExt.Empty;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static FileType Empty
        {
            [MethodImpl(Inline)]
            get => new FileType(typeof(void), FileKind.None, sys.empty<FS.FileExt>());
        }
    }
}