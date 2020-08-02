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
    /// Represents the PE header format.
    /// </summary>
    [Record]
    public struct IMAGE_NT_HEADERS
    {
        /// <summary>
        /// A 4-byte signature identifying the file as a PE image. The bytes are "PE\0\0".
        /// </summary>
        public uint Signature;

        /// <summary>
        /// An <see cref="IMAGE_FILE_HEADER"/> structure that specifies the file header.
        /// </summary>
        public IMAGE_FILE_HEADER FileHeader;

        /// <summary>
        /// An <see cref="IMAGE_OPTIONAL_HEADER"/> structure that specifies the optional file header.
        /// </summary>
        public IMAGE_OPTIONAL_HEADER OptionalHeader;
    }
}