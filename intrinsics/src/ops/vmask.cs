//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static vbuild;
    using static As;

    public static class vmask
    {
        /// <summary>
        /// [000...001]    
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant of each component is enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>());

        /// <summary>
        /// [01]    
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of every two bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N2 f)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f));

        /// <summary>
        /// [00010001]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of every four bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N4 f)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f));

        /// <summary>
        /// [00000001]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the least significant bit out of every eight bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f));

        /// <summary>
        /// [00000000 00000001]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Selects a mask where the least significant bit out of every 16 bits is enabled (componentwise)</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N16 f)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f));

        /// <summary>
        /// [00000011]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the least significant 2 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f, N2 d)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f,d));

        /// <summary>
        /// [00000111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the least significant 3 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f, N3 d)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f,d));

        /// <summary>
        /// [00001111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the least significant 4 bits of every 8-bit segment are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f, N4 d)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f,d));

        /// <summary>
        /// [00011111]
        /// Creates a mask where the least significant 5 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f, N5 d)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f,d));

        /// <summary>
        /// [00111111]
        /// Creates a mask where the least significant 6 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f, N6 d)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f,d));

        /// <summary>
        /// [01111111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the least significant 7 bits of every 8-bits are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f, N7 d)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(f,d));

        /// <summary>
        /// [100...000 ... 100...000]    
        /// Selects a mask where the most significant bit of each component is enabled
        /// </summary>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>());

        /// <summary>
        /// [01]    
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the most significant bit out of every two bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N2 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f));

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every four bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N4 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f));

        /// <summary>
        /// [10001000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks>Creates a mask where the most significant bit out of every eight bits is enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f));

        /// <summary>
        /// [10000000 00000000 10000000 00000000]
        /// Selects a mask where the most significant bit out of every 16 bits is enabled
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N16 n)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [11000000 11000000 11000000 11000000]
        /// Creates a mask where the 2 most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N2 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11100000 11100000 11100000 11100000]
        /// Creates a mask where the 3 most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N3 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11110000 11110000 11110000 11110000]
        /// Creates a mask where the 4 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N4 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111000 11111000 11111000 11111000]
        /// Creates a mask where the 5 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N5 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111100]
        /// Creates a mask where the 6 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N6 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111110 11111110 11111110 11111110]
        /// Creates a mask where the 7 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N7 f)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// Creates a mask where f most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, byte f)
            where T : unmanaged
                => vgeneric<T>(broadcast(w,BitMask.msb8f(f)));

        /// <summary>
        /// [00000000 00000000 00000000 00000001]    
        /// Selects a mask where the least significant of each component is enabled
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>());

        /// <summary>
        /// [01]    
        /// Selects a mask where the least significant bit out of every two bits is enabled on a per-component basis
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N2 n)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00010001]
        /// Selects a mask where the least significant bit out of every four bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N4 n)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000001 00000001 00000001 00000001]
        /// Selects a mask where the least significant bit out of every eight bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000000 00000001]
        /// Selects a mask where the least significant bit out of every 16 bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N16 n)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000011]
        /// Creates a mask where the least significant 2 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N2 f, T t = default)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00000111]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the least significant 3 bits of every 8-bit segment are enabled on a per-component basis</remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N3 f, T t = default)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00001111]
        /// Creates a mask where the least significant 4 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N4 f, T t = default)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00011111]
        /// Creates a mask where the least significant 5 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N5 f, T t = default)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00111111]
        /// Creates a mask where the least significant 6 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N6 f, T t = default)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [01111111]
        /// Creates a mask where the least significant 7 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="n">The repetition frequency</param>
        /// <param name="f">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N7 f, T t = default)
            where T : unmanaged
                => broadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// Creates a mask where the f least significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => vgeneric<T>(broadcast(w,BitMask.lsb8f(d)));

        /// <summary>
        /// Creates a mask where the f least significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => vgeneric<T>(broadcast(w,BitMask.lsb8f(d)));

        /// <summary>
        /// [10000000 00000000 00000000 00000000]    
        /// Selects a mask where the most significant bit of each component is enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, T t = default)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>());

        /// <summary>
        /// [01010101 01010101 01010101 01010101]    
        /// Selects a mask where the most significant bit out of every two bits is enabled
        /// </summary>
        /// <param name="n1">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N2 n)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every four bits is enabled
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N4 n)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every eight bits is enabled
        /// </summary>
        /// <param name="n">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10000000 00000000 10000000 00000000]
        /// Selects a mask where the most significant bit out of every 16 bits is enabled
        /// </summary>
        /// <param name="n1">The repetition frequency</param>
        /// <typeparam name="T">The mask data type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N16 n)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [11000000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the 2 most significant bits of every 8 bits are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 f, N2 d)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11100000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the 3 most significant bits of every 8 bits are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 f, N3 d)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11110000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the 4 most significant bits of every 8-bits are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 f, N4 d)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111000]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the 5 most significant bits of every 8-bits are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 f, N5 d)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111100]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the 6 most significant bits of every 8-bits are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 f, N6 d)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// [11111110]
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks>Creates a mask where the 6 most significant bits of every 8-bits are enabled</remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 f, N7 d)
            where T : unmanaged
                => broadcast(w,BitMask.msb<T>(f,d));

        /// <summary>
        /// Creates a mask where f most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        /// <remarks></remarks>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 f, byte d)
            where T : unmanaged
                => vgeneric<T>(broadcast(w,BitMask.msb8f(d)));
    }
}