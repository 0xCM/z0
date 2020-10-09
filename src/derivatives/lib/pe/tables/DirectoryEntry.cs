//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct ImageTables
    {
        /// <summary>
        /// Represents the data directory.
        /// </summary>
        /// <remarks>
        /// See remarks on MSDN: https://msdn.microsoft.com/en-us/library/windows/desktop/ms680305(v=vs.85).aspx.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential)]
        public struct DirectoryEntry
        {
            public int RelativeVirtualAddress;

            public int Size;
        }
    }
}