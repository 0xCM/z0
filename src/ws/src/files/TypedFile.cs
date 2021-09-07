//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TypedFile
    {
        public FileKind Kind {get;}

        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public TypedFile(FileKind kind, FS.FilePath path)
        {
            Kind = kind;
            Path = path;
        }

        public string Format()
            => Path.ToUri().Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TypedFile((FileKind kind, FS.FilePath path) src)
            => new TypedFile(src.kind, src.path);
    }
}