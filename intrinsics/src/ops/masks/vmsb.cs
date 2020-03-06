//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Root;    
    using static Nats;
    using static gvec;

    partial class vmask
    {
        /// <summary>
        /// [100...000 ... 100...000]    
        /// The greatest bit of each component is enabled
        /// </summary>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(n1,n1,t));

        /// <summary>
        /// [01]    
        /// The greatest bit of each 2-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N2 f, N1 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [1000]
        /// The greatest bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N4 f, N1 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [10000000]
        /// The greatest bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, N1 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [10000000 00000000]
        /// The greatest bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N16 f, N1 d, T t = default)
            where T : unmanaged
                => generic<T>(vbroadcast<ulong>(w, BitMask.msb(n64, f, d)));

        /// <summary>
        /// [11000000]
        /// The 2 greatest bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, N2 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [11100000]
        /// The greatest 3 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, N3 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11110000]
        /// The greatest 4 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, N4 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111000]
        /// The greatest 5 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, N5 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111100]
        /// The greatest 6 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, N6 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [11111110]
        /// The greatest 7 bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, N7 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// The f most significant bits of each 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vmsb<T>(N128 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => generic<T>(vbroadcast<byte>(w, BitMask.msb8f(d)));

        /// <summary>
        /// [100...00]    
        /// The greatest bit of each component is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(n1,n1,t));

        /// <summary>
        /// [01    
        /// The greatest bit of each 2-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N2 f, N1 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [1000]
        /// The greatest bit of each 4-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N4 f, N1 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f, d, t));

        /// <summary>
        /// [10000000]
        /// The greatest bit of each 8-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, N1 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [10000000 00000000]
        /// The greatest bit of each 16-bit segment is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The component data type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N16 f, N1 d, T t = default)
            where T : unmanaged
                => generic<T>(vbroadcast<ulong>(w, BitMask.msb(n64, f, d)));

        /// <summary>
        /// [11000000]
        /// The 2 greatest bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, N2 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [11100000]
        /// The 3 greatest bits of each 8-bit segment are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, N3 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb(f,d,t));

        /// <summary>
        /// [11110000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, N4 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, N5 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111100]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, N6 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111110]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, N7 d, T t = default)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// Creates a mask where f most significant bits of each 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vmsb<T>(N256 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => generic<T>(vbroadcast<byte>(w, BitMask.msb8f(d)));
    }
}