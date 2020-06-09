//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Control
    {
        /// <summary>
        /// Converts the source value to a bytespan
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> bytes2<T>(T src)
            where T : struct
                => MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan(ref src, Unsafe.SizeOf<T>()));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);
     
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => MemoryMarshal.AsBytes(MemoryMarshal.CreateSpan(ref edit(src), 1));
    }
}