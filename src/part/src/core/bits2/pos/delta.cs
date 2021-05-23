//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitPos
    {
		/// <summary>
		/// Computes the order-invariant absolute distance between two positions
		/// </summary>
		/// <param name="a">The left position</param>
		/// <param name="b">The right position</param>
		[MethodImpl(Inline)]
		public static uint delta(BitPos a, BitPos b)
			=> ScalarCast.uint32(root.abs((long)a.LinearIndex - (long)b.LinearIndex));
    }
}