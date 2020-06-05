//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct AsmSourceDoc
    {
        public FilePath SourcePath {get;}
        
        public TextDoc Text {get;}

        public AsmStatementBlock[] Blocks {get;}

        [MethodImpl(Inline)]
        public AsmSourceDoc(FilePath path, TextDoc src, AsmStatementBlock[] blocks)
        {
            Text = src;
            SourcePath = path;
            Blocks = blocks;
        }
    }
}