//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct FileFlows
    {
        [MethodImpl(Inline), Op]
        public static TypedFile typed(FileKind kind, FS.FilePath src)
            => (kind, src);

        [MethodImpl(Inline), Op]
        public static FileFlow<S,T> flow<S,T>(S src, T dst)
            where S : struct, ITypedFile
            where T : struct, ITypedFile
                => (src, dst);

        [MethodImpl(Inline), Op]
        public static FileFlow flow(TypedFile src, TypedFile dst)
            => (src, dst);

        [MethodImpl(Inline), Op]
        public static FileFlow flow(FileKind kSrc, FS.FilePath src, FileKind kDst, FS.FilePath dst)
            => flow(typed(kSrc, src), typed(kDst,dst));

        [MethodImpl(Inline), Op]
        public static FileFlow flow(Arrow<TypedFile> src)
            => flow(src.Source, src.Target);

    }
}