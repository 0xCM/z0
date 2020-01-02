//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Overwrites each row of a generic bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly BitMatrix<T> broadcast<T>(BitVector<T> x, in BitMatrix<T> A)
            where T : unmanaged
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref readonly BitMatrix8 broadcast(BitVector8 x, in BitMatrix8 A)
        {
            A.data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref readonly BitMatrix16 broadcast(BitVector16 x, in BitMatrix16 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref readonly BitMatrix32 broadcast(BitVector32 x, in BitMatrix32 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref readonly BitMatrix64 broadcast(BitVector64 x, in BitMatrix64 A)
        {
            A.Data.Fill(x);
            return ref A;
        }
    }
}