//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static FS;

    public readonly struct FileModule : IFileModule<FileModule>
    {
        public FS.FilePath Path {get;}

        public ModuleKind Kind {get;}

        public FileModule(FS.FilePath path,ModuleKind kind = default)
        {
            Path = path;
            Kind = kind;
        }
    }
}