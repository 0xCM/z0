//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileFlow : IDataFlow<TypedFile,TypedFile>
    {
        public TypedFile Source {get;}

        public TypedFile Target {get;}

        [MethodImpl(Inline)]
        public FileFlow(FileType srcType, FS.FilePath src,  FileType dstType, FS.FilePath dst)
        {
            Source = (srcType,src);
            Target = (dstType,dst);
        }


        [MethodImpl(Inline)]
        public FileFlow(TypedFile src, TypedFile dst)
        {
            Source = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileFlow((TypedFile src, TypedFile dst) x)
            => new FileFlow(x.src,x.dst);
    }
}