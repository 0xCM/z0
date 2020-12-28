//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static memory;

    partial struct AsmTables
    {
        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> encode(AsmSyntaxEncoding src)
            => src.Bytes;
    }
}