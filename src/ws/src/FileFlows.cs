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
        public static FileFlow flow(TypedFile src, TypedFile dst)
            => (src, dst);

        [MethodImpl(Inline), Op]
        public static FileFlow flow(string actor, TypedFile src, TypedFile dst)
            => new FileFlow(actor, src, dst);

        [MethodImpl(Inline), Op]
        public static FileFlow flow(FileKind kSrc, FS.FilePath src, FileKind kDst, FS.FilePath dst)
            => flow(typed(kSrc, src), typed(kDst,dst));

        [MethodImpl(Inline), Op]
        public static FileFlow flow(string actor, FileKind kSrc, FS.FilePath src, FileKind kDst, FS.FilePath dst)
            => flow(actor, typed(kSrc, src), typed(kDst,dst));

        [MethodImpl(Inline), Op]
        public static FileFlow flow(Arrow<TypedFile> src)
            => flow(src.Source, src.Target);

        [MethodImpl(Inline), Op]
        public static FileFlow flow(string actor, Arrow<TypedFile> src)
            => flow(actor, src.Source, src.Target);
    }
}