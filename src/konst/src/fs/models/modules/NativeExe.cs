//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FS
    {
        /// <summary>
        /// Identifies and represents a native module with an entry point
        /// </summary>
        public readonly struct NativeExe : IFileModule<NativeExe>
        {
            public FilePath Path {get;}

            [MethodImpl(Inline)]
            public NativeExe(FilePath path)
                => Path = path;

            public ModuleKind Kind
                => ModuleKind.NativeExe;

            [MethodImpl(Inline)]
            public static implicit operator FileModule(NativeExe src)
                => new FileModule(src.Path, src.Kind);
        }
    }
}