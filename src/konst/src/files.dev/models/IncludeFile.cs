//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = DevFiles;

    /// <summary>
    /// Represents a native executable
    /// </summary>
    public readonly struct IncludeFile : IFsEntry<IncludeFile>
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public IncludeFile(FS.FilePath src)
            => Path = src;

        public FS.PathPart Name
        {
            [MethodImpl(Inline)]
            get => Path.Name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator IncludeFile(FS.FilePath src)
            => new IncludeFile(src);

        public static IncludeFile Empty
        {
            [MethodImpl(Inline)]
            get => new IncludeFile(FS.FilePath.Empty);
        }
    }
}