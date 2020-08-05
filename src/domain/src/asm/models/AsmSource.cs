//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmSource
    {
        public readonly FilePath SourcePath;
        
        public readonly TextDoc Document;

        public readonly AsmStatementBlock[] Blocks;

        [MethodImpl(Inline)]
        public AsmSource(FilePath path, TextDoc src, AsmStatementBlock[] blocks)
        {
            Document = src;
            SourcePath = path;
            Blocks = blocks;
        }
    }
}