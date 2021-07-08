//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly ref struct AsmLine
    {
        public AsciLine Data {get;}

        public AsmLinePart Parts {get;}

        [MethodImpl(Inline), Op]
        public AsmLine(AsciLine src, AsmLinePart parts)
        {
            Data = src;
            Parts = parts;
        }
    }
}