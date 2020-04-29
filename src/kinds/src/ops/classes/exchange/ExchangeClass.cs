//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using OC = OperationClass;
    
    /// <summary>
    /// Classifies pure sinks, sources and brokers
    /// </summary>
    [Flags]
    public enum ExchangeClass : byte
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