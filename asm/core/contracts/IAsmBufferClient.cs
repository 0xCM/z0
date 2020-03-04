//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Defines the signature of a buffer client delegate
    /// </summary>
    /// <param name="buffers">The buffers available when invoked</param>
    public delegate void AsmBufferClient(in AsmBuffers buffers);

    /// <summary>
    /// Defines service contract for a buffered client
    /// </summary>
    public interface IAsmBufferClient : IAsmService
    {
        /// <summary>
        /// Exucutes client-specific operation that may use the supplied buffers
        /// </summary>
        /// <param name="buffers">The buffers available when invoked</param>
        void Execute(in AsmBuffers buffers);
    }
}