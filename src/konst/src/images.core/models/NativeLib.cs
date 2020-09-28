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
        /// Identifies and represents a native static library
        /// </summary>
        public readonly struct NativeLib : IFileModule<NativeLib>
        {
            public FilePath Path {get;}

            [MethodImpl(Inline)]
            public NativeLib(FilePath path)
                => Path = path;

            public ModuleKind Kind
                => ModuleKind.NativeLib;

            [MethodImpl(Inline)]
            public static implicit operator FileModule(NativeLib src)
                => new FileModule(src.Path, src.Kind);
        }
    }
}