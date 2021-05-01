//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class gbits
    {
        /// <summary>
        /// Defines a bit position, relative to a T-valued sequence, predicated on a linear index
        /// </summary>
        /// <param name="index">The sequence-relative index of the target bit</param>
        /// <typeparam name="T">The sequence element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitPos<T> bitpos<T>(int index)
            where T : unmanaged
				=> BitPos.FromBitIndex<T>((uint)index);

        /// <summary>
        /// Defines a bit position, relative to a T-valued sequence, predicated on a linear index
        /// </summary>
		/// <param name="index">The linear index</param>
        /// <param name="cell">The cell index</param>
        /// <param name="offset">The cell-relative offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
		public static void bitpos<T>(uint index, out ushort cell, out ushort offset)
            where T : unmanaged
        {
            var w = width<T>(w16);
			cell = BitPos.linear(w, index);
            offset = BitPos.offset(w, index);
        }
    }
}