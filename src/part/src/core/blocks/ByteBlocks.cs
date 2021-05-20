//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static Root;
    using static core;

    [ApiHost]
    public static partial class ByteBlocks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        internal static unsafe Vector128<byte> vload(W128 w, in byte src)
            => LoadDquVector128(gptr(src));

        [MethodImpl(Inline)]
        internal static unsafe Vector256<byte> vload(W256 w, in byte src)
            => LoadDquVector256(gptr(src));

        [MethodImpl(Inline)]
        internal static unsafe void vstore(Vector256<byte> src, ref byte dst)
            => Store(refptr(ref dst),src);

        [MethodImpl(Inline)]
        internal static unsafe void vstore(Vector128<byte> src, ref byte dst)
            => Store(refptr(ref dst), src);

        [MethodImpl(Inline)]
        internal static unsafe Vector128<byte> vbroadcast(W128 w, byte src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        internal static unsafe Vector256<byte> vbroadcast(W256 w, byte src)
            => BroadcastScalarToVector256(&src);
    }
}