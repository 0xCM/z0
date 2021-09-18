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
        public readonly struct McAsm : ITypedFile<McAsm>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public McAsm(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.McAsm;

            [MethodImpl(Inline)]
            public static implicit operator McAsm(FS.FilePath src)
                => new McAsm(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(McAsm src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(McAsm src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}