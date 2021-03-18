//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitMatrix
    {
        /// <summary>
        /// Queries the matrix for the data in an index-identified column
        /// </summary>
        /// <param name="index">The row index</param>
        public static BitVector4 col(in BitMatrix4 A, int index)
        {
            byte col = 0;
            for(var r = 0; r < BitMatrix4.N; r++)
                col = bit.set(col, (byte)r, bit.test(A[r].Content, (byte)index));
            return col;
        }

        [MethodImpl(Inline)]
        public static BitVector32 col(in BitMatrix32 A, int index)
        {
            uint col = 0;
            for(byte r = 0; r<A.Order; r++)
                col = Bits.setif(A[r], (byte)index, col, r);
            return col;
        }
    }
}