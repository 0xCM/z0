//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the Hadamard product of the source matrix and another of the same dimension
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Hadamard_product_(matrices)</remarks>
        public static BitMatrix16 hprod(in BitMatrix16 A, in BitMatrix16 B)
        {
            var C = BitMatrix16.Alloc();
            for(var i=0; i<A.Order; i++)
            for(var j=0; j<B.Order; j++)
                C[i,j] = A[i,j] & B[i,j];
            return C;
        }

        /// <summary>
        /// Computes the Hadamard product of the source matrix and another of the same dimension
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Hadamard_product_(matrices)</remarks>
        public static BitMatrix32 hprod(in BitMatrix32 A, in BitMatrix32 B)
        {
            var C = BitMatrix.alloc(n32);
            for(var i=0; i<A.Order; i++)
            for(var j=0; j<B.Order; j++)
                C[i,j] = A[i,j] & B[i,j];
            return C;
        }

        /// <summary>
        /// Computes the Hadamard product of the source matrix and another of the same dimension
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Hadamard_product_(matrices)</remarks>
        public static BitMatrix64 hprod(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix.alloc(n64);
            for(var i=0; i<A.Order; i++)
            for(var j=0; j<B.Order; j++)
                C[i,j] = A[i,j] & B[i,j];
            return C;
        }
    }
}