//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {


        /// <summary>
        /// Computes the Hadamard product of the source matrix and another of the same dimension
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Hadamard_product_(matrices)</remarks>
        public static BitMatrix32 hprod(BitMatrix32 A)
        {
            var B = BitMatrix32.Alloc();
            for(var i=0; i<A.RowCount; i++)
            for(var j=0; j<A.ColCount; j++)
                B[i,j] = A.GetBit(i,j) & A[i,j];
            return B;
        }

        /// <summary>
        /// Computes the Hadamard product of the source matrix and another of the same dimension
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Hadamard_product_(matrices)</remarks>
        public static BitMatrix64 hprod(BitMatrix64 A)
        {
            var B = BitMatrix64.Alloc();
            for(var i=0; i<A.RowCount; i++)
            for(var j=0; j<A.ColCount; j++)
                B[i,j] = A.GetBit(i,j) & A[i,j];
            return B;
        }
    }
}