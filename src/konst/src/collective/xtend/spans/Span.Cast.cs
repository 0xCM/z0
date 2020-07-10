//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Presents a u8 span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The Target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Cast<T>(this Span<byte> src)
            where T : struct
                => z.recover<byte,T>(src);

        /// <summary>
        /// Presents a u16 span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The Target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Cast<T>(this Span<ushort> src)
            where T : struct
                => z.recover<ushort,T>(src);

        /// <summary>
        /// Presents a u32 span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The Target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Cast<T>(this Span<uint> src)
            where T : struct
                => z.recover<uint,T>(src);

        /// <summary>
        /// Presents a u64 span as a T-span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The Target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Cast<T>(this Span<ulong> src)
            where T : struct
                => z.recover<ulong,T>(src);

        /// <summary>
        /// Presents a span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> Cast<S,T>(this Span<S> src)
            where S : struct
            where T : struct
                => z.recover<S,T>(src);

        /// <summary>
        /// Presents a readonly span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> Cast<S,T>(this ReadOnlySpan<S> src)
            where S : struct
            where T : struct
                => z.recover<S,T>(src);
    }
}