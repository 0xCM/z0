//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static ProjectFile;

    [ApiHost]
    public class FileTypes
    {
        [MethodImpl(Inline)]
        public static TypedFile<K> file<K>(FS.FilePath src)
            where K : struct, IFileType<K>
                => new TypedFile<K>(src);

        [MethodImpl(Inline), Op]
        public static TypedFile file(FileType type, FS.FilePath path)
            => new TypedFile(type,path);

        public static FileKind classify(FS.FilePath src)
            => default;

    }
}