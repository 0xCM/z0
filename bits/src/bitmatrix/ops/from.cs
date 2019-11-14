//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrix
    {        
        [MethodImpl(Inline)]
        public static BitMatrix4 from(N4 n, BitVector4[] src)
            => BitMatrix4.From(src);

        /// <summary>
        /// Constructs a bitmatrix formed from the ordered bitvector representation of the permutation symbols
        /// </summary>
        /// <param name="n"></param>
        /// <param name="perm"></param>
        /// <remarks>
        /// Example:
        /// Permutation: [11 10 00 01] (ABCD -> BACD)
        /// Bitmatrix:
        /// 1000
        /// 0000
        /// 0100
        /// 1100
        /// </remarks>
        public static BitMatrix4 from(N4 n, Perm4 perm)
        {
            var digits = perm.Digits();
            var rows = new BitVector4[4];
            for(var i=0; i<digits.Length; i++)
                rows[i] = BitVector.from(n4, digits[i]);
            return from(n4, rows);
        }

        [MethodImpl(Inline)]
        public static BitMatrix4 from(ushort src)
            => BitMatrix4.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 from(N8 n8, byte row0 = 0, byte row1 = 0, byte row2 = 0, byte row3 = 0, 
            byte row4 = 0, byte row5 = 0, byte row6 = 0, byte row7 = 0)
                => BitMatrix8.From(row0, row1, row2, row3, row4, row5, row6, row7);
        
        /// <summary>
        /// Creates a canonical permutation matrix by swapping matrix rows of the identity matrix as specified by a permutation
        /// </summary>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 from(Perm<N64> spec)
        {
            var id = BitMatrix64.Identity;
            permute(spec, ref id);
            return id;
        }

        /// <summary>
        /// Loads a generic bitmatrix from a rowbit sequence
        /// </summary>
        /// <param name="rows">The row content</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<T> from<T>(RowBits<T> src)
            where T : unmanaged
        {
            if(src.RowCount != bitsize<T>())
                Errors.Throw($"{bitsize<T>()} != {src.RowCount}");

            return load(src.data);                
        }
    }

}