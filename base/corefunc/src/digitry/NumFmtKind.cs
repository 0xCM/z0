//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static nfunc;

    [Flags]
    public enum NumFmtKind
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

    public static class NumFmtKindX
    {
        public static bool IsBinary(this NumFmtKind src)
            =>  (src & NumFmtKind.Binary) != 0;

        public static bool IsDecimal(this NumFmtKind src)
            =>  (src & NumFmtKind.Decimal) != 0;

        public static bool IsHex(this NumFmtKind src)
            =>  (src & NumFmtKind.Hex) != 0;
            
        public static bool IsBlocked(this NumFmtKind src)
            =>  (src & NumFmtKind.Blocked) != 0;

        public static bool IsPrefixed(this NumFmtKind src)
            =>  (src & NumFmtKind.Prefixed) != 0;

        public static bool IsSuffixed(this NumFmtKind src)
            =>  (src & NumFmtKind.Suffixed) != 0;

        public static bool IsZeroPadded(this NumFmtKind src)
            =>  (src & NumFmtKind.ZeroPadded) != 0;

    }
}