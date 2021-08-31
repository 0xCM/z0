//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TypedFile<T>
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

        public string Format()
            => Location.ToUri().Format();

        public override string ToString()
            => Format();
    }
}