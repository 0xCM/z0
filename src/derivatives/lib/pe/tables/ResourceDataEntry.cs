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
        /// Each resource data entry describes a leaf node in the resource directory
        /// tree.  It contains an offset, relative to the beginning of the resource
        /// directory of the data for the resource, a size field that gives the number
        /// of bytes of data at that offset, a CodePage that should be used when
        /// decoding code point values within the resource data.  Typically for new
        /// applications the code page would be the unicode code page.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct ResourceDataEntry
        {
            public int RvaToData;

            public int Size;

            public int CodePage;

            public int Reserved;
        }
    }
}