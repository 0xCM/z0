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
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    static class BitMatrixD
    {
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<byte> and(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
        {
            C.HeadAs<ulong>() = A.HeadAs<ulong>() & B.HeadAs<ulong>();
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<ushort> and(in BitMatrix<ushort> A,in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
        {
            BitPoints256.and(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<uint> and(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
        {
            BitPoints256.and(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix<ulong> and(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
        {
            BitPoints256.and(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static unsafe BitMatrix<ulong> and(in BitMatrix<ulong> A, in BitMatrix<ulong> B)
        {
            var C = BitMatrix.alloc<ulong>();
            BitPoints256.and(A.HeadPtr, B.HeadPtr, C.HeadPtr);
            return C;
        }


    }


}