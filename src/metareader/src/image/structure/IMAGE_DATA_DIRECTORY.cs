//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Represents the data directory.
    /// </summary>
    /// <remarks>
    /// See remarks on MSDN: https://msdn.microsoft.com/en-us/library/windows/desktop/ms680305(v=vs.85).aspx.
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_DATA_DIRECTORY
    {
        /// <summary>
        /// The relative virtual address of the table.
        /// </summary>
        public uint VirtualAddress;

        /// <summary>
        /// The size of the table, in bytes.
        /// </summary>
        public uint Size;
    }
}