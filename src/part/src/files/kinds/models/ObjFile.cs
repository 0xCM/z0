//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Identifies and represents a native static library
    /// </summary>
    public readonly struct ObjFile : IFileModule<ObjFile>
    {
        public FS.FilePath Path {get;}

        [MethodImpl(Inline)]
        public ObjFile(FS.FilePath path)
            => Path = path;

        public FileModuleKind ModuleKind
            => FileModuleKind.Obj;

        public FS.FileExt DefaultExt
            =>  FS.Obj;

        [MethodImpl(Inline)]
        public static implicit operator FileModule(ObjFile src)
            => new FileModule(src.Path, src.ModuleKind);

        [MethodImpl(Inline)]
        public static implicit operator ImagePath(ObjFile src)
            => src.Path;
    }
}