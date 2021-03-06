//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a labled statement block
    /// </summary>
    public readonly struct NasmOutputFile : IFile
    {
        public FS.FilePath Path {get;}

        public ObjFileKind Kind {get;}

        [MethodImpl(Inline)]
        public NasmOutputFile(FS.FilePath target, ObjFileKind kind)
        {
            Path = target;
            Kind = kind;
        }
    }
}