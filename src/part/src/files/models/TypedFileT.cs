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

    public readonly struct TypedFile<T> : ITypedFile<TypedFile<T>,T>
        where T : struct, IFileType<T>
    {
        public FS.FilePath Location {get;}

        public T Type => default;

        [MethodImpl(Inline)]
        public TypedFile(FS.FilePath path)
        {
            Location = path;
        }

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Location.Name;
        }

        public TypedFile Untyped
        {
            [MethodImpl(Inline)]
            get => api.untyped(this);
        }

        public string Format()
            => Location.ToUri().Format();

        public override string ToString()
            => Format();

        public static implicit operator TypedFile(TypedFile<T> src)
            => src.Untyped;
    }
}