//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<sbyte> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<byte> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<short> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<ushort> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<int> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<uint> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<long> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<ulong> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<float> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<double> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<sbyte> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<byte> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<short> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<ushort> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<int> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<uint> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<long> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<ulong> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<float> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<double> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<sbyte> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<byte> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<short> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<ushort> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<int> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<uint> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<long> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<ulong> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<float> src)
            where T : unmanaged
                => ref memory.generic<T>(src);

        [MethodImpl(Inline)]
        public static ref Vector512<T> generic<T>(in Vector512<double> src)
            where T : unmanaged
                => ref memory.generic<T>(src);
   }
}