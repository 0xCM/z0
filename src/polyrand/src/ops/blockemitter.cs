//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Sources
    {
        [MethodImpl(Inline), Op]
        public static SpanBlockEmitter blockemitter(IBoundSource src, Pow2x64 bufferSize = Pow2x64.P2ᐞ14)
            => new SpanBlockEmitter(src, bufferSize);

        [MethodImpl(Inline), Op]
        public static SpanBlockEmitter blockemitter(IBoundSource src, Index<Cell256> buffer)
            => new SpanBlockEmitter(src, buffer);
    }
}