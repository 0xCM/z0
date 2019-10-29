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
        /// Returns true if all bits in the source matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool testc<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitPoints.testc(A.HeadPtr);

        /// <summary>
        /// Returns true if all bits identified by a mask matrix are enabled in the source matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The mask matrix</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool testc<T>(in BitMatrix<T> A, in BitMatrix<T> M)
            where T : unmanaged
                => BitPoints.testc(A.HeadPtr, M.HeadPtr);

        /// <summary>
        /// Returns true if all bits in the source matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix8 A)
            => BitPoints.testc(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix8 A, in BitMatrix8 B)
            => BitPoints.testc(A.HeadPtr, B.HeadPtr);

        /// <summary>
        /// Returns true if all bits in the source matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix16 A)
            => BitPoints.testc(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix16 A, in BitMatrix16 B)
            => BitPoints.testc(A.HeadPtr, B.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix32 A)
            => BitPoints.testc(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix32 A, in BitMatrix32 B)
            => BitPoints.testc(A.HeadPtr, B.HeadPtr);

        /// <summary>
        /// Returns true if all bits in the source matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix64 A)
            => BitPoints.testc(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testc(in BitMatrix64 A, in BitMatrix64 B)
            => BitPoints.testc(A.HeadPtr, B.HeadPtr);
    }

}