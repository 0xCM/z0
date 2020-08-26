//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BufferedChecker : IBufferedChecker
    {
        readonly BufferAllocation BufferAlloc;

        public readonly BufferTokens Tokens {get;}

        [MethodImpl(Inline)]
        public BufferedChecker(uint length, byte count)
        {
            Tokens = Buffers.sequence(length, count, out BufferAlloc).Tokenize();
        }

        public void Dispose()
            => BufferAlloc.Dispose();
    }
}