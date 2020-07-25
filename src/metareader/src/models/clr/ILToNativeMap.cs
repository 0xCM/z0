//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

#pragma warning disable CA1051 // Do not declare visible instance fields

    partial struct ClrDataModel
    {
        /// <summary>
        /// A method's mapping from IL to native offsets.
        /// </summary>
        public struct ILToNativeMap
        {
            /// <summary>
            /// The IL offset for this entry.
            /// </summary>
            public int ILOffset;

            /// <summary>
            /// The native start offset of this IL entry.
            /// </summary>
            public ulong StartAddress;

            /// <summary>
            /// The native end offset of this IL entry.
            /// </summary>
            public ulong EndAddress;

            /// <summary>
            /// To string.
            /// </summary>
            /// <returns>A visual display of the map entry.</returns>
            public override string ToString()
            {
                return $"{ILOffset,2:X} - [{StartAddress:X}-{EndAddress:X}]";
            }

    #pragma warning disable CA1823
    #pragma warning disable 0169
    #pragma warning disable IDE0051 // Remove unused private members
            /// <summary>
            /// Reserved.
            /// </summary>
            private readonly int _reserved;
        }
    }
}