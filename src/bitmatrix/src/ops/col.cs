//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; using static Memories;

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
                col = Bit32.set(col, (byte)r, Bit32.test(A[r].Scalar, index));
            return col;
        }

        [MethodImpl(Inline)]
        public static BitVector32 col(in BitMatrix32 A, int index)
        {
            uint col = 0;
            for(var r = 0; r < A.Order; r++)
                col = Bits.setif(A[r], index, col, r);
            return col;
        }
    }
}