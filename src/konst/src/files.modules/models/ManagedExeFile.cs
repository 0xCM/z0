//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Represents a managed executable
    /// </summary>
    public readonly struct ManagedExeFile : IFileModule<ManagedExeFile>
    {
        /// <summary>
        /// The path to the represented file
        /// </summary>
        public FS.FilePath Path {get;}

        /// <summary>
        /// The assembly name
        /// </summary>
        public AssemblyName Name {get;}

        [MethodImpl(Inline)]
        public ManagedExeFile(FS.FilePath path, AssemblyName name)
        {
            Path = path;
            Name = name;
        }

        public FS.FileExt DefaultExt
            =>  FileExtensions.Exe;

        public FileModuleKind ModuleKind
            => FileModuleKind.ManagedExe;

        [MethodImpl(Inline)]
        public static implicit operator FileModule(ManagedExeFile src)
            => new FileModule(src.Path, src.ModuleKind);

        public Assembly Load()
            => Assembly.LoadFrom(Path.Name);
    }
}