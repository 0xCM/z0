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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<sbyte> vcast8i<T>(in Vector128<T> src)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<sbyte>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<byte> vcast8u<T>(in Vector128<T> src)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<byte>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<short> vcast16i<T>(in Vector128<T> src)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<short>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<ushort> vcast16u<T>(in Vector128<T> src)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<ushort>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref  Vector128<int> vcast32i<T>(in Vector128<T> src)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<int>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<uint> vcast32u<T>(in Vector128<T> src)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<uint>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<long> vcast64i<T>(in Vector128<T> src, NK<long> dst)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<long>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<ulong> vcast64u<T>(in Vector128<T> src, NK<ulong> dst)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<ulong>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<float> vcast32f<T>(in Vector128<T> src, NK<float> dst)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<float>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<double> vcast64f<T>(in Vector128<T> src, NK<double> dst)
            where T : unmanaged
                => ref @as<Vector128<T>,Vector128<double>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<sbyte> vcast8i<T>(in Vector256<T> src, NK<sbyte> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<sbyte>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<byte> vcast8u<T>(in Vector256<T> src, NK<byte> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<byte>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<short> vcast16i<T>(in Vector256<T> src, NK<short> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<short>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<ushort> vcast16u<T>(in Vector256<T> src, NK<ushort> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<ushort>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref  Vector256<int> vcast32i<T>(in Vector256<T> src, NK<int> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<int>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<uint> vcast32u<T>(in Vector256<T> src, NK<uint> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<uint>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<long> vcast64i<T>(in Vector256<T> src, NK<long> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<long>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<ulong> vcast64u<T>(in Vector256<T> src, NK<ulong> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<ulong>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<float> vcast<T>(in Vector256<T> src, NK<float> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<float>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<double> vcast<T>(in Vector256<T> src, NK<double> dst)
            where T : unmanaged
                => ref @as<Vector256<T>,Vector256<double>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<sbyte> vcast<T>(in Vector512<T> src, NK<sbyte> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<sbyte>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<byte> vcast<T>(in Vector512<T> src, NK<byte> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<byte>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<short> vcast<T>(in Vector512<T> src, NK<short> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<short>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<ushort> vcast<T>(in Vector512<T> src, NK<ushort> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<ushort>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref  Vector512<int> vcast<T>(in Vector512<T> src, NK<int> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<int>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<uint> vcast<T>(in Vector512<T> src, NK<uint> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<uint>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<long> vcast<T>(in Vector512<T> src, NK<long> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<long>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<ulong> vcast<T>(in Vector512<T> src, NK<ulong> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<ulong>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<float> vcast<T>(in Vector512<T> src, NK<float> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<float>>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<double> vcast<T>(in Vector512<T> src, NK<double> dst)
            where T : unmanaged
                => ref @as<Vector512<T>,Vector512<double>>(src);
    }
}