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

    public readonly struct AsmDoc
    {
        public FilePath SourcePath {get;}
        
        public TextDoc Text {get;}

        [MethodImpl(Inline)]
        public AsmDoc(FilePath path, TextDoc src)
        {
            Text = src;
            SourcePath = path;
        }
    }
}