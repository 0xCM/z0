//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using static Seed;

    public enum CommonFieldWidths
    {
        /// <summary>
        /// The width of a sequence number field
        /// </summary>
        Sequence = 10,

        /// <summary>
        /// The width of a count field
        /// </summary>
        Count = 8,

        /// <summary>
        /// The width of a boolean field with a concise header
        /// </summary>
        Bool = 8,

        /// <summary>
        /// The width of a boolean field with a not-so-concise header
        /// </summary>
        BoolLarge = 14,

        /// <summary>
        /// The width of a field containing an 8-bit decimal number
        /// </summary>
        Num8Dec = 8,

        /// <summary>
        /// The width of a field containing an 8-bit hex number
        /// </summary>
        Num8Hex = 8,

    }

}