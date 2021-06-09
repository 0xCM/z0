//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
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

        public NasmOutFileKind Kind {get;}

        public NasmOutputFile(FS.FilePath target, NasmOutFileKind kind)
        {
            Path = target;
            Kind = kind;
        }
    }
}