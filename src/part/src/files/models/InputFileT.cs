//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

   public readonly struct InputFile<T> : IFsEntry<InputFile<T>,T>
        where T : unmanaged
    {
        public FS.FilePath Path {get;}

        public T Kind {get;}

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Path.Name;
        }

        [MethodImpl(Inline)]
        public InputFile(FS.FilePath src, T kind)
        {
            Path = src;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator FS.FilePath(InputFile<T> src)
            => src.Path;

        [MethodImpl(Inline)]
        public static implicit operator InputFile(InputFile<T> src)
            => src.Path;
    }
}