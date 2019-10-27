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
        
        [MethodImpl(Inline)]
        public static unsafe bool testz<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitPoints.testz(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitPoints.testz(A.HeadPtr, B.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix8 A)
            => BitPoints.testz(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix8 A, in BitMatrix8 B)
            => BitPoints.testz(A.HeadPtr, B.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix16 A)
            => BitPoints.testz(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix16 A, in BitMatrix16 B)
            => BitPoints.testz(A.HeadPtr, B.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix32 A)
            => BitPoints.testz(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix32 A, in BitMatrix32 B)
            => BitPoints.testz(A.HeadPtr, B.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix64 A)
            => BitPoints.testz(A.HeadPtr);

        [MethodImpl(Inline)]
        public static unsafe bool testz(in BitMatrix64 A, in BitMatrix64 B)
            => BitPoints.testz(A.HeadPtr, B.HeadPtr);
    }
}