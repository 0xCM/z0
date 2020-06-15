//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        

    public enum CommonFieldWidths
    {
        /// <summary>
        /// The width of a sequence number field
        /// </summary>
        Sequence = 10,

        /// <summary>
        /// The width of a programmatic identifier field
        /// </summary>
        Identifier = 40,

        /// <summary>
        /// The width of a field that contains summary descriptive information
        /// </summary>
        Description = 80,

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

        /// <summary>
        /// The width of a field containing an 8-bit decimal number
        /// </summary>
        Num16Dec = 10,

        /// <summary>
        /// The width of a field containing an 8-bit hex number
        /// </summary>
        Num16Hex = 10,

        /// <summary>
        /// The width of a field containing an 8-bit decimal number
        /// </summary>
        Num32Dec = 14,

        /// <summary>
        /// The width of a field containing an 8-bit hex number
        /// </summary>
        Num32Hex = 14,

        /// <summary>
        /// The width of a field containing an 8-bit decimal number
        /// </summary>
        Num64Dec = 16,

        /// <summary>
        /// The width of a field containing an 8-bit hex number
        /// </summary>
        Num64Hex = 16,

        /// <summary>
        /// The index of the bit at which width specification begins 
        /// </summary>
        Offset = 16,
    }
}