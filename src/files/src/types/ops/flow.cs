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
        public static FileFlow flow(TypedFile src, TypedFile dst)
            => (src,dst);

        [MethodImpl(Inline)]
        public static FileFlow<S,T> flow<S,T>(TypedFile<S> src, TypedFile<T> dst)
            where S : struct, IFileType<S>
            where T : struct, IFileType<T>
                => (src,dst);

    }
}