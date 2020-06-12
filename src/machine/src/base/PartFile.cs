//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartFile
    {        
        public readonly PartId Part;

        public readonly FilePath Path;

        [MethodImpl(Inline)]
        public PartFile(PartId part, FilePath path)
        {
            Part = part;
            Path = path;
        }
    }
}