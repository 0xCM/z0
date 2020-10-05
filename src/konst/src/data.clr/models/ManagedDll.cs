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
    /// Identifies and represents and managaged module that lacks an entry point
    /// </summary>
    public readonly struct ManagedDll : IFileModule<ManagedDll>
    {
        /// <summary>
        /// The file's path
        /// </summary>
        public FS.FilePath Path {get;}

        /// <summary>
        /// The assembly name
        /// </summary>
        public AssemblyName Name {get;}

        [MethodImpl(Inline)]
        public ManagedDll(FS.FilePath path, AssemblyName name)
        {
            Path = path;
            Name = name;
        }

        public FileModuleKind Kind
            => FileModuleKind.ManagedDll;

        [MethodImpl(Inline)]
        public static implicit operator FileModule(ManagedDll src)
            => new FileModule(src.Path, src.Kind);

        public ClrAssembly Load()
            => Assembly.LoadFrom(Path.Name);
    }
}