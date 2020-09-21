//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        public readonly struct FileModule : IFileModule<FileModule>
        {
            public FilePath Path {get;}

            public ModuleKind Kind {get;}

            [MethodImpl(Inline)]
            public FileModule(FilePath src, ModuleKind kind)
            {
                Path = src;
                Kind = kind;
            }
        }
    }
}