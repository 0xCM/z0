//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static nfunc;

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

    public static class NumericFormatKindOps
    {
        public static bool IsBinary(this NumericFormatKind src)
            =>  (src & NumericFormatKind.Binary) != 0;

        public static bool IsDecimal(this NumericFormatKind src)
            =>  (src & NumericFormatKind.Decimal) != 0;

        public static bool IsHex(this NumericFormatKind src)
            =>  (src & NumericFormatKind.Hex) != 0;
            
        public static bool IsBlocked(this NumericFormatKind src)
            =>  (src & NumericFormatKind.Blocked) != 0;

        public static bool IsPrefixed(this NumericFormatKind src)
            =>  (src & NumericFormatKind.Prefixed) != 0;

        public static bool IsSuffixed(this NumericFormatKind src)
            =>  (src & NumericFormatKind.Suffixed) != 0;

        public static bool IsZeroPadded(this NumericFormatKind src)
            =>  (src & NumericFormatKind.ZeroPadded) != 0;

    }
}