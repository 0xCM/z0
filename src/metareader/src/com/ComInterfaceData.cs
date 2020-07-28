//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ClrDataModel
    {
        /// <summary>
        /// The COM implementation details of a single CCW entry.
        /// </summary>
        public struct ComInterfaceData
        {
            /// <summary>
            /// Gets the CLR type this represents.
            /// </summary>
            public ClrType Type { get; }

            /// <summary>
            /// Gets the interface pointer of Type.
            /// </summary>
            public ulong InterfacePointer { get; }

            public ComInterfaceData(ClrType type, ulong pointer)
            {
                Type = type;
                InterfacePointer = pointer;
            }
        }               
    }
}