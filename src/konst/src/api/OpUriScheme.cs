//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum OpUriScheme
    {
        None = 0,
        
        /// <summary>
        /// Marker for operations emitted to a decoded asm file
        /// </summary>
        Asm,
        
        /// <summary>
        /// Marker for operations emitted to a hex-formatted file
        /// </summary>
        Hex,

        /// <summary>
        /// Marker for stateless hosted operations
        /// </summary>
        Type,

        /// <summary>
        /// Marker for serviced hosted operations
        /// </summary>
        Svc,

        /// <summary>
        /// Marker for memory-located operations
        /// </summary>
        Located,

        /// <summary>
        /// Scheme used when origin/location semantics should be eliminated from consideration
        /// </summary>
        Any,
    }
}