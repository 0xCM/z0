//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Defines primary API surface for span manipulation
    /// </summary>
    public static class Spans
    {

        /// <summary>
        /// Presents the content of a value of unmanaged type as a span of bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsSpan<T>(ref T src)
            where T : unmanaged
                => new Span<byte>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<T>());

        /// <summary>
        /// Presents the content of a value of unmanaged type as a span of values of a specified target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Span<T> AsSpan<S,T>(ref S src)
            where T : unmanaged
            where S : unmanaged
                    => new Span<byte>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<T>()).As<byte,T>();

    }


}