//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Characterizes a test service that provides access to a buffer sequence
    /// </summary>
    public interface IBufferedChecker : TChecker, IServiceAllocation, IBufferTokenSource
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
}