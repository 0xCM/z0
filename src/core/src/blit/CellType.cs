//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Specifies a concrete data type
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public readonly struct CellType
    {
        /// <summary>
        /// The primal storage class
        /// </summary>
        public readonly PrimalClass Class;

        /// <summary>
        /// The physical bit width
        /// </summary>
        public readonly uint Capacity;

        /// <summary>
        /// The count of used bits
        /// </summary>
        public readonly uint DataWidth;

        [MethodImpl(Inline)]
        public CellType(PrimalClass kind, BitWidth storage, BitWidth content)
        {
            Class = kind;
            Capacity = storage;
            DataWidth = content;
        }
    }
}