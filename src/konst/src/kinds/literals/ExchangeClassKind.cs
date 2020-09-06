//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClassKind;
    
    /// <summary>
    /// Classifies pure sinks, sources and brokers
    /// </summary>
    [Flags]
    public enum ExchangeClassKind : byte
    {
        /// <summary>
        /// Classifies nothing
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Classifies a pure source
        /// </summary>
        Source = (byte)OC.Emitter,

        /// <summary>
        /// Classifies a pure sink
        /// </summary>
        Sink = (byte)OC.Receiver,

        /// <summary>
        /// Classifies a source/sink intermediary
        /// </summary>        
        Broker = Source | Sink
    }
}