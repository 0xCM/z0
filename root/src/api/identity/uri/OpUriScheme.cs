//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

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
        Stateless,

        /// <summary>
        /// Marker for serviced hosted operations
        /// </summary>
        Serviced,

        /// <summary>
        /// Marker for memory-located operations
        /// </summary>
        Located,

        /// <summary>
        /// Scheme used when origin/location semantics should be eliminated from consideration
        /// </summary>
        Any,
    }

    public static class OpUriSchemeOps
    {
       public static string Format(this OpUriScheme src)
            => src.ToString().ToLower();

    }
}