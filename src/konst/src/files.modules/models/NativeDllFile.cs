//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = NativeModules;

    /// <summary>
    /// Represents a native dll
    /// </summary>
    public readonly struct NativeDllFile : IFileModule<NativeDllFile>
    {
        public FS.FilePath Path {get;}

        public FileModuleKind ModuleKind
            => FileModuleKind.NativeDll;

        [MethodImpl(Inline)]
        public NativeDllFile(FS.FilePath path)
            => Path = path;

        public FS.FileExt DefaultExt
            =>  ArchiveFileExt.Dll;

        [MethodImpl(Inline)]
        public static implicit operator FileModule(NativeDllFile src)
            => new FileModule(src.Path, src.ModuleKind);

        [MethodImpl(Inline)]
        public NativeModule Load()
            => api.load(Path);
    }
}