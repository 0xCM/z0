//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public partial class InstructionTokenData
    {
        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> span(string src)
            => src;        

        [MethodImpl(Inline)]
        static MemoryAddress address(string src)
            => MemoryAddress.from(Control.head(span(src)));            

        public const int TokenCount = (int)InstructionToken.TokenCount;
    }
}