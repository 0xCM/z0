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
        public readonly FileKind FileKind;

        public readonly FS.FilePath Path;

        [MethodImpl(Inline)]
        public TypedFile(FileKind kind, FS.FilePath path)
        {
            FileKind = kind;
            Path = path;
        }

        FileKind ITypedFile.FileKind
            => FileKind;

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