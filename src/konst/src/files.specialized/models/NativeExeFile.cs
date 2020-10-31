//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents a native executable
    /// </summary>
    public readonly struct NativeExeFile : IFileModule<NativeExeFile>
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public NativeExeFile(FS.FilePath path)
            => Path = path;

        public FileModuleKind ModuleKind
            => FileModuleKind.NativeExe;

        public FS.FileExt DefaultExt
            =>  ArchiveFileKinds.Exe;

        [MethodImpl(Inline)]
        public static implicit operator FileModule(NativeExeFile src)
            => new FileModule(src.Path, src.ModuleKind);
    }
}