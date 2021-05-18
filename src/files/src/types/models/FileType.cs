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
        public Type RuntimeType {get;}

        public FileKind FileKind {get;}

        public Index<FS.FileExt> Extensions {get;}

        [MethodImpl(Inline)]
        public FileType(Type rtt, FileKind kind, FS.FileExt[] extensions)
        {
            RuntimeType = rtt;
            FileKind = kind;
            Extensions = extensions;
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