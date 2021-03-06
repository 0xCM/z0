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
        [MethodImpl(Inline), Op]
        public static FileType type(Type rep, FileKind kind, FS.FileExt ext)
            => new FileType(rep, kind, ext);

        public static TypedFile untyped<T>(TypedFile<T> src)
            where T : struct, IFileType<T>
                => new TypedFile(new FileType(src.Type.Rep, src.Type.FileKind, src.Type.FileExt), src.Location);
    }
}