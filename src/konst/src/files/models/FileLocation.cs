//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct FileLocation : ILocation<FS.FilePath>
    {
        public FS.FilePath Locator {get;}

        [MethodImpl(Inline)]
        public FileLocation(FS.FilePath src)
            => Locator = src;

        [MethodImpl(Inline)]
        public static implicit operator FileLocation(FS.FilePath src)
            => new FileLocation(src);

        [MethodImpl(Inline)]
        public FS.FileUri ToUri()
            => Locator.ToUri();

        public string FormatUri()
            => ToUri().Format();

        public string FormatPath(PathSeparator sep = PathSeparator.BS)
            => Locator.Format(sep);

        public string Format()
            => FormatUri();

        public override string ToString()
            => Format();

        public static FileLocation Empty
        {
            [MethodImpl(Inline)]
            get => new FileLocation(FS.FilePath.Empty);
        }
    }
}