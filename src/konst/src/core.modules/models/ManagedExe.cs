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

    partial struct FS
    {
        /// <summary>
        /// Identifies and represents and managaged module with an entry point
        /// </summary>
        public readonly struct ManagedExe : IFileModule<ManagedExe>
        {
            /// <summary>
            /// The path to the represented file
            /// </summary>
            public FilePath Path {get;}

            /// <summary>
            /// The assembly name
            /// </summary>
            public AssemblyName Name {get;}

            [MethodImpl(Inline)]
            public ManagedExe(FilePath path, AssemblyName name)
            {
                Path = path;
                Name = name;
            }

            public ModuleKind Kind
                => ModuleKind.ManagedExe;

            [MethodImpl(Inline)]
            public static implicit operator FileModule(ManagedExe src)
                => new FileModule(src.Path, src.Kind);
        }
    }
}