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

        public BinaryModuleKind ModuleKind {get;}

        [MethodImpl(Inline)]
        public FileModule(FS.FilePath src, BinaryModuleKind kind)
        {
            Path = src;
            ModuleKind = kind;
        }

        public FS.FileExt DefaultExt
            => ModuleKind switch {
                BinaryModuleKind.Dll => FS.Extensions.Dll,
                BinaryModuleKind.Exe => FS.Extensions.Exe,
                BinaryModuleKind.Lib => FS.Extensions.Lib,
                _ =>  FS.FileExt.Empty
            };
        [MethodImpl(Inline)]
        public static implicit operator FileModule(FileModule<T> src)
            => new FileModule(src.Path,src.ModuleKind);
    }
}