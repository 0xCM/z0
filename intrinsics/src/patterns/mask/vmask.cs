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
        /// [00000000 00000000 00000000 00000001]    
        /// Selects a mask where the least significant of each component is enabled
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>());

        /// <summary>
        /// [01010101 01010101 01010101 01010101]    
        /// Selects a mask where the least significant bit out of every two bits is enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N2 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00010001 00010001 00010001 00010001]
        /// Selects a mask where the least significant bit out of every four bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N4 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000001 00000001 00000001 00000001]
        /// Selects a mask where the least significant bit out of every eight bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000000 00000001 00000000 00000001]
        /// Selects a mask where the least significant bit out of every 16 bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N16 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000011 00000011 00000011 00000011]
        /// Creates a mask where the least significant 2 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n, N2 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00000111 00000111 00000111 00000111]
        /// Creates a mask where the least significant 3 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n, N3 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00001111 00001111 00001111 00001111]
        /// Creates a mask where the least significant 4 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n, N4 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00011111 00011111 00011111 00011111]
        /// Creates a mask where the least significant 5 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n, N5 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00111111 00111111 00111111 00111111]
        /// Creates a mask where the least significant 6 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n, N6 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [01111111 01111111 01111111 01111111]
        /// Creates a mask where the least significant 7 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n, N7 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [10000000 00000000 00000000 00000000]    
        /// Selects a mask where the most significant bit of each component is enabled
        /// </summary>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>());

        /// <summary>
        /// [01010101 01010101 01010101 01010101]    
        /// Selects a mask where the most significant bit out of every two bits is enabled
        /// </summary>
        /// <param name="n1">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N2 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every four bits is enabled
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N4 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every eight bits is enabled
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10000000 00000000 10000000 00000000]
        /// Selects a mask where the most significant bit out of every 16 bits is enabled
        /// </summary>
        /// <param name="n1">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N16 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [11000000 11000000 11000000 11000000]
        /// Creates a mask where the 2 most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N2 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11100000 11100000 11100000 11100000]
        /// Creates a mask where the 3 most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N3 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11110000 11110000 11110000 11110000]
        /// Creates a mask where the 4 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N4 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111000 11111000 11111000 11111000]
        /// Creates a mask where the 5 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N5 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111100 11111100 11111100 11111100]
        /// Creates a mask where the 6 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N6 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111110 11111110 11111110 11111110]
        /// Creates a mask where the 7 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, N7 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// Creates a mask where f most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> msb<T>(N128 w, N8 n, byte f)
            where T : unmanaged
                => vgeneric<T>(vbroadcast(w,BitMask.msb8f(f)));

        /// <summary>
        /// [00000000 00000000 00000000 00000001]    
        /// Selects a mask where the least significant of each component is enabled
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>());

        /// <summary>
        /// [01010101 01010101 01010101 01010101]    
        /// Selects a mask where the least significant bit out of every two bits is enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N2 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00010001 00010001 00010001 00010001]
        /// Selects a mask where the least significant bit out of every four bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N4 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000001 00000001 00000001 00000001]
        /// Selects a mask where the least significant bit out of every eight bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000000 00000001 00000000 00000001]
        /// Selects a mask where the least significant bit out of every 16 bits is enabled on a per-component basis
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N16 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n));

        /// <summary>
        /// [00000011 00000011 00000011 00000011]
        /// Creates a mask where the least significant 2 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N2 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00000111 00000111 00000111 00000111]
        /// Creates a mask where the least significant 3 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N3 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00001111 00001111 00001111 00001111]
        /// Creates a mask where the least significant 4 bits of every 8-bit segment are enabled on a per-component basis
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N4 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00011111 00011111 00011111 00011111]
        /// Creates a mask where the least significant 5 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N5 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [00111111 00111111 00111111 00111111]
        /// Creates a mask where the least significant 6 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N6 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// [01111111 01111111 01111111 01111111]
        /// Creates a mask where the least significant 7 bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, N7 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.lsb<T>(n,f));

        /// <summary>
        /// Creates a mask where the f least significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> lsb<T>(N128 w, N8 n, byte f)
            where T : unmanaged
                => vgeneric<T>(vbroadcast(w,BitMask.lsb8f(f)));

        /// <summary>
        /// Creates a mask where the f least significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> lsb<T>(N256 w, N8 n, byte f)
            where T : unmanaged
                => vgeneric<T>(vbroadcast(w,BitMask.lsb8f(f)));

        /// <summary>
        /// [10000000 00000000 00000000 00000000]    
        /// Selects a mask where the most significant bit of each component is enabled
        /// </summary>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>());

        /// <summary>
        /// [01010101 01010101 01010101 01010101]    
        /// Selects a mask where the most significant bit out of every two bits is enabled
        /// </summary>
        /// <param name="n1">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N2 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every four bits is enabled
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N4 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10001000 10001000 10001000 10001000]
        /// Selects a mask where the most significant bit out of every eight bits is enabled
        /// </summary>
        /// <param name="n">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [10000000 00000000 10000000 00000000]
        /// Selects a mask where the most significant bit out of every 16 bits is enabled
        /// </summary>
        /// <param name="n1">The characteristic selector</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N16 n)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n));

        /// <summary>
        /// [11000000 11000000 11000000 11000000]
        /// Creates a mask where the 2 most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n, N2 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11100000 11100000 11100000 11100000]
        /// Creates a mask where the 3 most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n, N3 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11110000 11110000 11110000 11110000]
        /// Creates a mask where the 4 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n, N4 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111000 11111000 11111000 11111000]
        /// Creates a mask where the 5 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n, N5 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111100 11111100 11111100 11111100]
        /// Creates a mask where the 6 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n, N6 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// [11111110 11111110 11111110 11111110]
        /// Creates a mask where the 7 most significant bits of every 8-bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">The characteristic factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n, N7 f)
            where T : unmanaged
                => vbroadcast(w,BitMask.msb<T>(n,f));

        /// <summary>
        /// Creates a mask where f most significant bits of every 8 bits are enabled
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="n">The characteristic selector</param>
        /// <param name="f">A value in the range [2,7] that defines the msb duplication factor</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> msb<T>(N256 w, N8 n, byte f)
            where T : unmanaged
                => vgeneric<T>(vbroadcast(w,BitMask.msb8f(f)));



    }
}