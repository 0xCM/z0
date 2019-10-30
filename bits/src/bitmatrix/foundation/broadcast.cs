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
        /// <summary>
        /// Creates a new generic bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<T> broadcast<T>(BitVector<T> src)
            where T : unmanaged
                => new BitMatrix<T>(src);

        /// <summary>
        /// Overwrites each row of a generic bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<T> broadcast<T>(BitVector<T> x, ref BitMatrix<T> A)
            where T : unmanaged
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 broadcast(BitVector8 x)
        {
            var A = alloc(n8);
            A.Data.Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix8 broadcast(BitVector8 x, ref BitMatrix8 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 broadcast(BitVector16 x)
        {
            var A = alloc(n16);
            A.Data.Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix16 broadcast(BitVector16 x, ref BitMatrix16 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 broadcast(BitVector32 x)
        {
            var A = alloc(n32);
            A.Data.Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix32 broadcast(BitVector32 x, ref BitMatrix32 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

        /// <summary>
        /// Creates a new primal bitmatrix where each row is initialized to a common source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static BitMatrix64 broadcast(BitVector64 x)
        {
            var A = alloc(n64);
            A.Data.Fill(x);
            return A;
        }

        /// <summary>
        /// Overwrites each row of a primal bitmatrix with a specified source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="A">The target matrix</param>
        [MethodImpl(Inline)]
        public static ref BitMatrix64 broadcast(BitVector64 x, ref BitMatrix64 A)
        {
            A.Data.Fill(x);
            return ref A;
        }

    }
}