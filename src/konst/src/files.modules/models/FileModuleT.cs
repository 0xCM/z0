//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct FileModule<T> : IFileModule<FileModule<T>,T>
        where T : struct, IFileModule<T>
    {
        public FS.FilePath Path {get;}

        public FileModuleKind ModuleKind {get;}

        [MethodImpl(Inline)]
        public FileModule(FS.FilePath src, FileModuleKind kind)
        {
            Path = src;
            ModuleKind = kind;
        }

        public FS.FileExt DefaultExt
            => ModuleKind switch {
                FileModuleKind.Dll => FS.Extensions.Dll,
                FileModuleKind.Exe => FS.Extensions.Exe,
                FileModuleKind.Lib => FS.Extensions.Lib,
                _ =>  FS.FileExt.Empty
            };
        [MethodImpl(Inline)]
        public static implicit operator FileModule(FileModule<T> src)
            => new FileModule(src.Path,src.ModuleKind);
    }
}