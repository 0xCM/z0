//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct InputFile : IFsEntry<InputFile>
    {
        public FS.FilePath Path {get;}

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Path.Name;
        }

        [MethodImpl(Inline)]
        public InputFile(FS.FilePath src)
            => Path = src;

        [MethodImpl(Inline)]
        public static implicit operator InputFile(FS.FilePath src)
            => new InputFile(src);

        [MethodImpl(Inline)]
        public static implicit operator FS.FilePath(InputFile src)
            => src.Path;
    }
}