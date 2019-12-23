//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BlockExtend    
    {

        /// <summary>
        /// Constructs a 32-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block16<T> Blocked<T>(this Span<T> src, N16 n)
             where T : unmanaged
                => DataBlocks.load(n,src);

        /// <summary>
        /// Constructs a 32-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block32<T> Blocked<T>(this Span<T> src, N32 n)
             where T : unmanaged
                => DataBlocks.load(n,src);

        /// <summary>
        /// Constructs a 16-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> Blocked<T>(this Span<T> src, N64 n)
             where T : unmanaged
                => DataBlocks.load(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> Blocked<T>(this Span<T> src, N128 n)
             where T : unmanaged
                => DataBlocks.load(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Blocked<T>(this Span<T> src, N256 n)
             where T : unmanaged
                => DataBlocks.load(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block512<T> Blocked<T>(this Span<T> src, N512 n)
             where T : unmanaged
                => DataBlocks.load(n,src);


    }

}