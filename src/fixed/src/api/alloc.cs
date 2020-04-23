//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Fixed
    {        
        /// <summary>
        /// Creates a fixed-type value of parametric type
        /// </summary>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static F alloc<F>()
            where F : unmanaged, IFixed
                => default(F);

        /// <summary>
        /// Creates an 8-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static Fixed8 alloc(W8 w)
            => default(Fixed8);

        /// <summary>
        /// Creates a 16-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static Fixed16 alloc(W16 w)
            => default(Fixed16);

        /// <summary>
        /// Creates a 32-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static Fixed32 alloc(W32 w)
            => default(Fixed32);

        /// <summary>
        /// Creates a 64-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static Fixed64 alloc(W64 w)
            => default(Fixed64);

        /// <summary>
        /// Creates a 128-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static Fixed128 alloc(W128 w)
            => default(Fixed128);

        /// <summary>
        /// Creates a 256-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static Fixed256 alloc(W256 w)
            => default(Fixed256);

        /// <summary>
        /// Creates a 512-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static Fixed512 alloc(W512 w)
            => default(Fixed512);
    }
}