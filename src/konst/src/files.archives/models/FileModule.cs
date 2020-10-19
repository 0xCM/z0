//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileModule : IFileModule<FileModule>
    {
        public FS.FilePath Path {get;}

        public FileModuleKind Kind {get;}

        [MethodImpl(Inline)]
        public FileModule(FS.FilePath src, FileModuleKind kind)
        {
            Path = src;
            Kind = kind;
        }
    }
}