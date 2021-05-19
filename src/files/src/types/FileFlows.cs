//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileFlows
    {
        [MethodImpl(Inline)]
        public static FileFlow<S,T> create<S,T>(FilePath<S> src, FilePath<T> dst)
            where S : struct, IFilePath<S>, IFileType<S>
            where T : struct, IFilePath<T>, IFileType<T>
                => new FileFlow<S,T>(src,dst);

        [MethodImpl(Inline)]
        public static FileFlow<S,P,T> create<S,P,T>(FilePath<S> src, P processor, FilePath<T> dst)
            where S : struct, IFilePath<S>, IFileType<S>
            where T : struct, IFilePath<T>, IFileType<T>
            where P : IFileProcessor<S,T>
                => new FileFlow<S,P,T>(src,processor, dst);
    }
}