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

    partial class Spans
    {
        /// <summary>
        /// Presents the bytespan head as a reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte head8<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort head16<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the bytespan head as a reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint head32<T>(Span<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 8-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly byte head8<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,byte>(ref MemoryMarshal.GetReference(src));    

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ushort head16<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ushort>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong head64<T>(Span<T> src)
            where T : unmanaged
                => ref head(src.AsUInt64());

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly ulong head64<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,ulong>(ref MemoryMarshal.GetReference(src));

        /// <summary>
        /// Presents the span head as a readonly reference to an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly uint head32<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => ref Unsafe.As<T,uint>(ref MemoryMarshal.GetReference(src));
 
        /// <summary>
        /// Presents the span head as a reference to a signed 32-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly int head32i(ReadOnlySpan<byte> src)
            => ref head(src.AsInt32());

        /// <summary>
        /// Presents the span head as a reference to a signed 64-bit integer
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ref readonly long head64i(ReadOnlySpan<byte> src)
            => ref head(src.AsInt64());
    }
}