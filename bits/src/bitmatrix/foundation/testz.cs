//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is defined</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool testz<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitPoints.testz(A.HeadPtr);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is defined</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool testz<T>(in BitMatrix<T> A, in BitMatrix<T> M)
            where T : unmanaged
                => BitPoints.testz(A.HeadPtr, M.HeadPtr);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix8 A)
            => BitPoints.testz(A.HeadPtr);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix8 A, in BitMatrix8 M)
            => BitPoints.testz(A.HeadPtr, M.HeadPtr);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix16 A)
            => BitPoints.testz(A.HeadPtr);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix16 A, in BitMatrix16 M)
            => BitPoints.testz(A.HeadPtr, M.HeadPtr);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix32 A)
            => BitPoints.testz(A.HeadPtr);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix32 A, in BitMatrix32 M)
            => BitPoints.testz(A.HeadPtr, M.HeadPtr);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix64 A)
            => BitPoints.testz(A.HeadPtr);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix64 A, in BitMatrix64 M)
            => BitPoints.testz(A.HeadPtr, M.HeadPtr);
    }
}