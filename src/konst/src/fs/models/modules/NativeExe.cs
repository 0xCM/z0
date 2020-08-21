//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.IO;

    using static Konst;

    partial struct FS
    {

        /// <summary>
        /// Identifies and represents a native module with an entry point
        /// </summary>
        public readonly struct NativeExe : IModule<NativeExe>
        {
            public FilePath Path {get;}

            [MethodImpl(Inline)]
            public NativeExe(FilePath path)
            {
                Path = path;
            }

            public ModuleKind Kind
                => ModuleKind.NativeExe;
        }
    }
}