//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines primal type widths via powers-of-two
    /// </summary>    
    public enum Pow2Width : byte
    {
        /// <summary>
        /// Witless, i.e. width-indeteriminate/variable
        /// </summary>    
        w0 = 0,

        /// <summary>
        /// W1 := 2^(w0) = 1, an imaginary but conceptually useful primal width
        /// </summary>    
        w1 = 0b001,

        /// <summary>
        /// W8 := 2^(W8) = 2^3 = 8
        /// </summary>    
        w8 = 0b011,

        /// <summary>
        /// W16 := 2^(W16) = 2^4 = 16
        /// </summary>    
        w16 = 0b100,

        /// <summary>
        /// W16 := 2^(W32) = 2^5 = 32
        /// </summary>    
        w32 = 0b101,

        /// <summary>
        /// W64 := 2^(W64) = 2^6 = 64
        /// </summary>    
        w64 = 0b101,

        /// <summary>
        /// W128 := 2^(W128) = 2^7 = 128
        /// </summary>    
        w128 = 0b111,

        /// <summary>
        /// The maximum specified width
        /// </summary>    
        wMax = 128,
    }
}