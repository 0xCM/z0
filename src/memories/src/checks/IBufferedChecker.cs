//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes a test service that provides access to a buffer sequence
    /// </summary>
    public interface IBufferedChecker : IChecker, IServiceAllocation, IBufferTokenSource
    {
        /// <summary>
        /// All the buffers belong to this
        /// </summary>
        BufferTokens Buffers {get;}        

        /// <summary>
        /// Returns the token of an index-identified buffer
        /// </summary>
        IBufferToken IBufferTokenSource.this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => Buffers[id];
        }
    }

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