//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    /// <summary>
    /// Expected values for the <see cref="Magic"/> field.
    /// </summary>
    public enum MagicType : ushort
    {
        /// <summary>
        /// The file is a 32-bit executable image.
        /// </summary>
        IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10b,

        /// <summary>
        /// The file is a 64-bit executable image.
        /// </summary>
        IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20b,

        /// <summary>
        /// The file is a ROM image.
        /// </summary>
        IMAGE_ROM_OPTIONAL_HDR_MAGIC = 0x107,
    }
}