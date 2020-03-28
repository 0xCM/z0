//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    partial class BitMatrix
    {
        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is defined</typeparam>
        [MethodImpl(Inline)]
        public static bit testz<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitSquare.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is defined</typeparam>
        [MethodImpl(Inline)]
        public static bit testz<T>(in BitMatrix<T> A, in BitMatrix<T> M)
            where T : unmanaged
                => BitSquare.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix8 A)
            => BitSquare.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix8 A, in BitMatrix8 M)
            => BitSquare.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix16 A)
            => BitSquare.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix16 A, in BitMatrix16 M)
            => BitSquare.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix32 A)
            => BitSquare.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix32 A, in BitMatrix32 M)
            => BitSquare.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix64 A)
            => BitSquare.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix64 A, in BitMatrix64 M)
            => BitSquare.testz(in A.Head, in M.Head);
    }
}