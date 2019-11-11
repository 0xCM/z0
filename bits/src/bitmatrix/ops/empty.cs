//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Determines whether the matrix is 0-filled
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit empty<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitMatrix.testz(A);

        /// <summary>
        /// Determines whether the matrix is 0-filled
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit empty(in BitMatrix8 A)
            => BitMatrix.testz(A);

        /// <summary>
        /// Determines whether the matrix is 0-filled
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit empty(in BitMatrix16 A)
            => BitMatrix.testz(A);

        /// <summary>
        /// Determines whether the matrix is 0-filled
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit empty(in BitMatrix32 A)
            => BitMatrix.testz(A);

        /// <summary>
        /// Determines whether the matrix is 0-filled
        /// </summary>
        [MethodImpl(Inline)] 
        public static bit empty(in BitMatrix64 A)
            => BitMatrix.testz(A);
    }
}