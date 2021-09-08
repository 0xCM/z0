//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TypedFile : ITypedFile
    {
        public readonly FileKind Kind;

        public readonly FS.FilePath Path;

        [MethodImpl(Inline)]
        public TypedFile(FileKind kind, FS.FilePath path)
        {
            Kind = kind;
            Path = path;
        }

        FileKind ITypedFile.Kind
            => Kind;

        FS.FilePath IFile.Path
            => Path;

        public string Format()
            => Path.ToUri().Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TypedFile((FileKind kind, FS.FilePath path) src)
            => new TypedFile(src.kind, src.path);
    }
}