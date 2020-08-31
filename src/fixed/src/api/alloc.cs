//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Fixed
    {
        /// <summary>
        /// Creates a fixed-type value of parametric type
        /// </summary>
        /// <typeparam name="F">The fixed type</typeparam>
        [MethodImpl(Inline)]
        public static F alloc<F>()
            where F : unmanaged, IFixedCell
                => default(F);

        /// <summary>
        /// Creates an 8-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static FixedCell8 alloc(W8 w)
            => default(FixedCell8);

        /// <summary>
        /// Creates a 16-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static FixedCell16 alloc(W16 w)
            => default(FixedCell16);

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
        public static FixedCell64 alloc(W64 w)
            => default(FixedCell64);

        /// <summary>
        /// Creates a 128-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static FixedCell128 alloc(W128 w)
            => default(FixedCell128);

        /// <summary>
        /// Creates a 256-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static FixedCell256 alloc(W256 w)
            => default(FixedCell256);

        /// <summary>
        /// Creates a 512-bit value
        /// </summary>
        /// <param name="w">The bit-width selector</typeparam>
        [MethodImpl(Inline), Op]
        public static FixedCell512 alloc(W512 w)
            => default(FixedCell512);
    }
}