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

    public readonly struct TypedFile : ITypedFile<TypedFile,FileType>
    {
        public FileType Type {get;}

        public FS.FilePath Location {get;}

        [MethodImpl(Inline)]
        public TypedFile(FileType type, FS.FilePath path)
        {
            Type = type;
            Location = path;
        }

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Location.Name;
        }

        public string Format()
            => Location.ToUri().Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TypedFile((FileType type, FS.FilePath path) src)
            => new TypedFile(src.type, src.path);
    }
}