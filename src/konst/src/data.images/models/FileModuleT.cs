//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileModule<T> : IFileModule<FileModule<T>,T>
        where T : struct, IFileModule<T>
    {
        public FS.FilePath Path {get;}

        public FileModuleKind Kind {get;}

        [MethodImpl(Inline)]
        public FileModule(FS.FilePath src, FileModuleKind kind)
        {
            Path = src;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator FileModule(FileModule<T> src)
            => new FileModule(src.Path,src.Kind);
    }

}