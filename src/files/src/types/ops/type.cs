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
        public static FileType type(Type rep, FileKind kind, params FS.FileExt[] ext)
            => new FileType(rep, kind, ext);

        [MethodImpl(Inline), Op]
        public static T type<T>()
            where T : struct, IFileType<T>
                => default(T);

        public static TypedFile untyped<T>(TypedFile<T> src)
            where T : struct, IFileType<T>
                => new TypedFile(new FileType(src.Type.Rep, src.Type.FileKind, src.Type.Extensions), src.Location);
    }
}