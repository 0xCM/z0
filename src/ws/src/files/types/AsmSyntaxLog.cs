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
        public readonly struct AsmSyntaxLog : ITypedFile<AsmSyntaxLog>
        {
            public FS.FilePath Path {get;}

            [MethodImpl(Inline)]
            public AsmSyntaxLog(FS.FilePath path)
            {
                Path = path;
            }

            public FileKind Kind
                => FileKind.AsmSyntaxLog;

            [MethodImpl(Inline)]
            public static implicit operator AsmSyntaxLog(FS.FilePath src)
                => new AsmSyntaxLog(src);

            [MethodImpl(Inline)]
            public static implicit operator FS.FilePath(AsmSyntaxLog src)
                => src.Path;

            [MethodImpl(Inline)]
            public static implicit operator TypedFile(AsmSyntaxLog src)
                => new TypedFile(src.Kind, src.Path);
        }
    }
}