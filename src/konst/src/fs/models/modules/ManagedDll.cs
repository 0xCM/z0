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
        /// Identifies and represents and managaged module that lacks an entry point
        /// </summary>
        public readonly struct ManagedDll : IModule<ManagedDll>
        {
            /// <summary>
            /// The file's path
            /// </summary>
            public FilePath Path {get;}

            /// <summary>
            /// The assembly name
            /// </summary>
            public AssemblyName Name {get;}

            [MethodImpl(Inline)]
            public ManagedDll(FilePath path, AssemblyName name)
            {
                Path = path;
                Name = name;
            }

           public ModuleKind Kind
                => ModuleKind.ManagedDll;
        }
    }
}