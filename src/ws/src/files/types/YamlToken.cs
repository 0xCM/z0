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
        public readonly struct YamlToken : ITypedFile<YamlToken>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public YamlToken(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.YamlTok;

            [MethodImpl(Inline)]
            public static implicit operator YamlToken(FS.FilePath src)
                => new YamlToken(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(YamlToken src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(YamlToken src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}