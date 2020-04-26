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
    public interface IBufferedChecker : IChecker, IServiceAllocation
    {
        /// <summary>
        /// All the buffers belong to this
        /// </summary>
        IBufferToken[] Buffers {get;}        

        /// <summary>
        /// Returns the token of an index-identified buffer
        /// </summary>
        IBufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => Buffers[(int)id];
        }
    }

    public readonly struct BufferedChecker : IBufferedChecker
    {
        readonly BufferAllocation BufferAlloc;

        public readonly IBufferToken[] Buffers {get;}

        [MethodImpl(Inline)]
        public static IBufferedChecker Create(int length, int count)
            => new BufferedChecker(length, count);

        [MethodImpl(Inline)]
        public BufferedChecker(int length, int count)
        {
            Buffers = BufferSeq.alloc(length, count, out BufferAlloc).Tokenize();            
        }
         
        public void Dispose()
            => BufferAlloc.Dispose();
    }
}