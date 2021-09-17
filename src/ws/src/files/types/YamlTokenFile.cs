//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class FileTypes
    {
        public readonly struct YamlTokenFile : ITypedFile<YamlTokenFile>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public YamlTokenFile(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.YamlTok;

            [MethodImpl(Inline)]
            public static implicit operator YamlTokenFile(FS.FilePath src)
                => new YamlTokenFile(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(YamlTokenFile src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(YamlTokenFile src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}