//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;

    static partial class cpufunc
    {

        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vload(N128 n, in byte src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vload(N128 n, in sbyte src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vload(N128 n, in short src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vload(N128 n, in ushort src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vload(N128 n, in int src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vload(N128 n, in uint src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vload(N128 n, in long src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vload(N128 n, in ulong src)
            => LoadDquVector128(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vload(N256 n, in byte src)
            => LoadDquVector256(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vload(N256 n, in sbyte src)
            => LoadDquVector256(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vload(N256 n, in short src)
            => LoadDquVector256(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vload(N256 n, in ushort src)
            => LoadDquVector256(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vload(N256 n, in int src)
            => LoadDquVector256(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vload(N256 n, in uint src)
            => LoadDquVector256(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vload(N256 n, in long src)
            => LoadDquVector256(constptr(src));

        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vload(N256 n, in ulong src)
            => LoadDquVector256(constptr(src));

    }

}