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
        public readonly struct McOpsAsmFile : ITypedFile<McOpsAsmFile>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public McOpsAsmFile(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.McOpsAsm;

            [MethodImpl(Inline)]
            public static implicit operator McOpsAsmFile(FS.FilePath src)
                => new McOpsAsmFile(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(McOpsAsmFile src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(McOpsAsmFile src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}