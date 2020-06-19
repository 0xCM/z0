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

        public readonly BufferTokens Buffers {get;}

        [MethodImpl(Inline)]
        public static IBufferedChecker Create(int length, byte count)
            => new BufferedChecker(length, count);

        [MethodImpl(Inline)]
        public BufferedChecker(int length, byte count)
        {
            Buffers = BufferSeq.alloc(length, count, out BufferAlloc).Tokenize();            
        }
         
        public void Dispose()
            => BufferAlloc.Dispose();
    }
}