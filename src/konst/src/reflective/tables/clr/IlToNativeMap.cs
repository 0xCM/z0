//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ClrTables
    {
        /// <summary>
        /// A method's mapping from IL to native offsets.
        /// </summary>
        [Table]
        public struct ILToNativeMap
        {
            public const string DisplayPattern = "{0,2:X} - [{1}-{2}]";

            public const string RenderPattern = "{0,-12} | {1,-12} | {2,-12}";

            /// <summary>
            /// The IL offset for this entry.
            /// </summary>
            public Address32 ILOffset;

            /// <summary>
            /// The native start offset of this IL entry.
            /// </summary>
            public MemoryAddress StartAddress;

            /// <summary>
            /// The native end offset of this IL entry.
            /// </summary>
            public MemoryAddress EndAddress;

            /// <summary>
            /// Reserved.
            /// </summary>
            readonly int _reserved;

            /// <summary>
            /// To string.
            /// </summary>
            /// <returns>A visual display of the map entry.</returns>
            public string Format()
                => text.format(DisplayPattern, ILOffset, StartAddress, EndAddress);
        }
    }
}