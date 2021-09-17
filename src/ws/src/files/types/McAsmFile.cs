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
        public readonly struct McAsmFile : ITypedFile<McAsmFile>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public McAsmFile(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.McAsm;

            [MethodImpl(Inline)]
            public static implicit operator McAsmFile(FS.FilePath src)
                => new McAsmFile(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(McAsmFile src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(McAsmFile src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}