//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Root;

    /// <summary>
    /// Defines a labled statement block
    /// </summary>
    public readonly struct NasmOutputFile : IFile
    {
        public FS.FilePath Path {get;}

        public AsmBinKind Kind {get;}

        [MethodImpl(Inline)]
        public NasmOutputFile(FS.FilePath target, AsmBinKind kind)
        {
            Path = target;
            Kind = kind;
        }
    }
}