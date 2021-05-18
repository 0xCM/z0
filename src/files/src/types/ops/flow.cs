//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct FileTypes
    {
        [MethodImpl(Inline)]
        public static FileFlow<S,T> flow<S,T>(FilePath<S> src, FilePath<T> dst)
            where S : struct, IFilePath<S>, IFileType<S>
            where T : struct, IFilePath<T>, IFileType<T>
                => new FileFlow<S,T>(src,dst);
    }
}