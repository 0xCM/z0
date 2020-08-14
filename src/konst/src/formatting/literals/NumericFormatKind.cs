//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Flags]
    public enum NumericFormatKind
    {        
        /// <summary>
        /// Indicates the scalar is formated in binary
        /// </summary>
        Binary = 1,

        /// <summary>
        /// Indicates the scalar is formated in decimal
        /// </summary>
        Decimal = 2,

        /// <summary>
        /// Indicates the scalar is formated in hex
        /// </summary>
        Hex = 4,

        /// <summary>
        /// Indicates the scalar is block-formated 
        /// </summary>
        Blocked = 128,

        /// <summary>
        /// Indicates the scalar is prefixed with the format type (when defined)
        /// </summary>
        Prefixed = 256,

        /// <summary>
        /// Indicates the scalar is suffixed with a character that identfies the numeric type (when defined)
        /// </summary>
        Suffixed = 512,
        
        /// <summary>
        /// Indicates the scalar is left-padded with zeroes to occupy the full length of the type
        /// </summary>
        ZeroPadded = 1024,

        HexBlocks = Hex | Blocked,

        BinBlocks = Binary | Blocked
    }
}