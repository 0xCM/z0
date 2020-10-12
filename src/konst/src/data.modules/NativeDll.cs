//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Native;

    /// <summary>
    /// Identifies and represents a native module that lacks  an entry point
    /// </summary>
    public readonly struct NativeDll : IFileModule<NativeDll>
    {
        public FS.FilePath Path {get;}

        public FileModuleKind Kind
            => FileModuleKind.NativeLib;

        [MethodImpl(Inline)]
        public NativeDll(FS.FilePath path)
            => Path = path;

        [MethodImpl(Inline)]
        public static implicit operator FileModule(NativeDll src)
            => new FileModule(src.Path, src.Kind);

        [MethodImpl(Inline)]
        public NativeModule Load()
            => api.load(Path);
    }
}