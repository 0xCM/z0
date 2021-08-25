//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static BitMasks;
    using static BitMaskLiterals;
    using static core;

    [ApiHost]
    public readonly struct vmask
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines a mask that disables a sequence of bits
        /// </summary>
        /// <param name="start">The index at which to begin</param>
        /// <param name="count">The number of bits to disable</param>
        /// <typeparam name="T">The primal type over which the mask is defined</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T eraser<T>(byte start, byte count)
            where T : unmanaged
                => gmath.xor(Limits.maxval<T>(), gmath.sll(BitMasks.lo<T>((byte)(count - 1)), start));


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(in Bitfield256<T> src, byte index)
            where T : unmanaged
                => BitMasks.lo<T>(src.SegWidth(index));

        [MethodImpl(Inline)]
        public static T mask<E,T>(in Bitfield256<E,T> src, E index)
            where E : unmanaged
            where T : unmanaged
                => BitMasks.lo<T>(src.SegWidth(index));

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcentral(W128 w, W8 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central8x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcentral(W128 w, W16 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central16x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(W128 w, W32 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central32x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(W128 w, W64 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central64x4x2);

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcentral(W128 w, W8 t, N8 f, N4 d)
            => cpu.vbroadcast(w, Central8x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcentral(W128 w, W16 t, N8 f, N4 d)
            => cpu.vbroadcast(w, Central16x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(W128 w, W32 t, N8 f, N4 d)
            => cpu.vbroadcast(w, Central32x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(W128 w, W64 t, N8 f, N4 d)
            => cpu.vbroadcast(w,  Central64x8x4);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcentral(W128 w, W16 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central16x16x8);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(W128 w, W32 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central32x16x8);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(W128 w, W64 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central64x16x8);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcentral(W128 w, W32 t, N32 f, N16 d)
            => cpu.vbroadcast(w, Central32x32x16);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(W128 w, W64 t, N32 f, N16 d)
            => cpu.vbroadcast(w, Central64x32x16);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vcentral(W128 w, W64 t, N64 f, N32 d)
            => cpu.vbroadcast(w, Central64x64x32);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcentral(W256 w, W8 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central8x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcentral(W256 w, W16 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central16x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(W256 w, W32 t, N4 f, N2 d)
            => gcpu.vbroadcast<uint>(w,  Central32x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(W256 w, W64 t, N4 f, N2 d)
            => cpu.vbroadcast(w, Central64x4x2);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vcentral(W256 w, W8 t, N4 f, N4 d)
            => cpu.vbroadcast(w,  Central8x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcentral(W256 w, W16 t, N4 f, N4 d)
            => cpu.vbroadcast(w,  Central16x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(W256 w, W32 t, N4 f, N4 d)
            => gcpu.vbroadcast<uint>(w,  Central32x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(W256 w, W64 t, N4 f, N4 d)
            => cpu.vbroadcast(w, Central64x8x4);

        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vcentral(W256 w, W16 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central16x16x8);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(W256 w, W32 t, N16 f, N8 d)
            => gcpu.vbroadcast<uint>(w,  Central32x16x8);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(W256 w, W64 t, N16 f, N8 d)
            => cpu.vbroadcast(w, Central64x16x8);

        [MethodImpl(Inline), Op]
        public static Vector256<uint> vcentral(W256 w, W32 t, N32 f, N16 d)
            => gcpu.vbroadcast<uint>(w,  Central32x32x16);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(W256 w, W64 t, N32 f, N16 d)
            => cpu.vbroadcast(w, Central64x32x16);

        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vcentral(W256 w, W64 t, N64 f, N32 d)
            => cpu.vbroadcast(w, Central64x64x32);

        /// <summary>
        /// The least bit of each cell is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N1 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d,t));

        /// <summary>
        /// [01]
        /// The least bit of each 2-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N2 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb<T>(f,d,t));

        /// <summary>
        /// [0001]
        /// The least bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N4 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb(f,d,t));

        /// <summary>
        /// [00000001]
        /// The least bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, N1 d)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb<T>(f,d));

        /// <summary>
        /// [00000000 00000001]
        /// The least bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N16 f, N1 d)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<ulong>(w, lsb64(f, d)));

        /// <summary>
        /// [00000011]
        /// The least 2 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, N2 d)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb<T>(f,d));

        /// <summary>
        /// [00000111]
        /// The least 3 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, N3 d)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb<T>(f,d));

        /// <summary>
        /// [00001111]
        /// The least 4 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, N4 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d));

        /// <summary>
        /// [00011111]
        /// The least 5 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, N5 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d));

        /// <summary>
        /// [00111111]
        /// The least 6 bits of each 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, N6 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb(f,d,t));

        /// <summary>
        /// [01111111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, N7 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb(f,d,t));

        /// <summary>
        /// [00....01]
        /// The least bit of each component is enabled
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N1 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb(f,d,t));

        /// <summary>
        /// [01 01 01 01]
        /// The least bit of each 2-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N2 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb(f,d,t));

        /// <summary>
        /// [0001 0001]
        /// The least bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N4 f, N1 d,T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d,t));

        /// <summary>
        /// [00000001]
        /// The least bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, N1 d,T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d,t));

        /// <summary>
        /// [00000000 00000001]
        /// The least significant bit out of each 16 bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N16 f, N1 d,T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<ulong>(w, lsb64(f, d)));

        /// <summary>
        /// [00000011]
        /// The least significant 2 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, N2 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d));

        /// <summary>
        /// [00000111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, N3 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d));

        /// <summary>
        /// [00001111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, N4 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb<T>(f,d));

        /// <summary>
        /// [00011111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, N5 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w,lsb<T>(f,d));

        /// <summary>
        /// [00111111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, N6 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d));

        /// <summary>
        /// [01111111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, N7 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, lsb<T>(f,d));

        /// <summary>
        /// The f least significant bits of each 8 bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vlsb<T>(W128 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<byte>(w, lsb8f(d)));

        /// <summary>
        /// The f least significant bits of each 8 bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vlsb<T>(W256 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<byte>(w, lsb8f(d)));

        /// <summary>
        /// The greatest bit of each cell is enabled
        /// </summary>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(n1,n1,t));

        /// <summary>
        /// [01]
        /// The greatest bit of each 2-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N2 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [1000]
        /// The greatest bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N4 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [10000000]
        /// The greatest bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [10000000 00000000]
        /// The greatest bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N16 f, N1 d, T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<ulong>(w, msb(n64, f, d)));

        /// <summary>
        /// [11000000]
        /// The 2 greatest bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, N2 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [11100000]
        /// The greatest 3 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, N3 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb<T>(f,d));

        /// <summary>
        /// [11110000]
        /// The greatest 4 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, N4 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb<T>(f,d));

        /// <summary>
        /// [11111000]
        /// The greatest 5 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, N5 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb<T>(f,d));

        /// <summary>
        /// [11111100]
        /// The greatest 6 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, N6 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [11111110]
        /// The greatest 7 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, N7 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// The f most significant bits of each 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vmsb<T>(W128 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<byte>(w, msb8f(d)));

        /// <summary>
        /// [100...00]
        /// The greatest bit of each component is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(n1,n1,t));

        /// <summary>
        /// [01
        /// The greatest bit of each 2-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N2 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [1000]
        /// The greatest bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N4 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f, d, t));

        /// <summary>
        /// [10000000]
        /// The greatest bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [10000000 00000000]
        /// The greatest bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N16 f, N1 d, T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<ulong>(w, msb(n64, f, d)));

        /// <summary>
        /// [11000000]
        /// The 2 greatest bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, N2 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [11100000]
        /// The 3 greatest bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, N3 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb(f,d,t));

        /// <summary>
        /// [11110000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, N4 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb<T>(f,d));

        /// <summary>
        /// [11111000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, N5 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb<T>(f,d));

        /// <summary>
        /// [11111100]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, N6 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb<T>(f,d));

        /// <summary>
        /// [11111110]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, N7 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, msb<T>(f,d));

        /// <summary>
        /// Creates a mask where f most significant bits of each 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vmsb<T>(W256 w, N8 f, byte d)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<byte>(w, msb8f(d)));

        /// <summary>
        /// [01010101] | [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> veven<F,D,T>(W128 w, F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(D) == typeof(N1))
                return veven<T>(w, n2, n1);
            else if(typeof(D) == typeof(N2))
                return veven<T>(w, n2, n2);
            else
                throw no<D>();
        }

        /// <summary>
        /// [01010101] | [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> veven<F,D,T>(W256 w, F f = default, D d = default, T t = default)
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
        {
            if(typeof(D) == typeof(N1))
                return veven<T>(w, n2, n1);
            else if(typeof(D) == typeof(N2))
                return veven<T>(w, n2, n2);
            else
                throw no<D>();
        }

        /// <summary>
        /// [01010101]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> veven<T>(W128 w, N2 f, N1 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, even<T>(f,d));

        /// <summary>
        /// [01010101]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> veven<T>(W256 w, N2 f, N1 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, even<T>(f,d));

        /// <summary>
        /// [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> veven<T>(W128 w, N2 f, N2 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, even<T>(f,d));

        /// <summary>
        /// [00110011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> veven<T>(W256 w, N2 f, N2 d, T t = default)
            where T : unmanaged
                => gcpu.vbroadcast(w, even<T>(f,d));

        [MethodImpl(Inline), Op]
        public static Vector128<byte> veven(W128 w)
            => veven<byte>(w, n2, n2);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> veven(W256 w)
            => veven<byte>(w, n2, n2);

        /// <summary>
        /// [10101010]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vodd<T>(W128 w, N2 f, N1 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, odd<T>(f,d));

        /// <summary>
        /// [10101010]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vodd<T>(W256 w, N2 f, N1 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, odd<T>(f,d));

        /// <summary>
        /// [11001100]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector128<T> vodd<T>(W128 w, N2 f, N2 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, odd<T>(f,d));

        /// <summary>
        /// [11001100]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A component type representative</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Vector256<T> vodd<T>(W256 w, N2 f, N2 d)
            where T : unmanaged
                => gcpu.vbroadcast(w, odd<T>(f,d));

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vodd(W128 w)
            => vodd<byte>(w, n2, n2);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> vodd(W256 w)
            => vodd<byte>(w, n2, n2);

        [MethodImpl(Inline), Op]
        public static Vector128<byte> hexbins(W128 w)
            => gcpu.vload(w, HexBins128);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> hexbins(W256 w)
            => gcpu.vload(w, HexBins256);

        static ReadOnlySpan<byte> HexBins128 => new byte[16]{
            0x00, 0x10, 0x20, 0x30, 0x40, 0x50, 0x60, 0x70, 0x80, 0x90, 0xA0, 0xB0, 0xC0, 0xD0,0xE0, 0xF0,
            };

        static ReadOnlySpan<byte> HexBins256 => new byte[32]{
            0x00, 0x10, 0x20, 0x30, 0x40, 0x50, 0x60, 0x70, 0x80, 0x90, 0xA0, 0xB0, 0xC0, 0xD0,0xE0, 0xF0,
            0x00, 0x10, 0x20, 0x30, 0x40, 0x50, 0x60, 0x70, 0x80, 0x90, 0xA0, 0xB0, 0xC0, 0xD0,0xE0, 0xF0,
            };
    }
}