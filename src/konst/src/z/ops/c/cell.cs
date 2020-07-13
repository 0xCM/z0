//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Reads a generic value from the head of a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Int8x64k)]
        public static T cell<T>(ReadOnlySpan<byte> src)
            where T : unmanaged        
                => read<T>(src);

        /// <summary>
        /// Reads a generic value beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index at which span consumption should begin</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Int8x64k)]
        public static T cell<T>(ReadOnlySpan<byte> src, int offset)
            where T : unmanaged        
                => read<T>(slice(src,offset));

        /// <summary>
        /// Reads a generic value from the head of a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline), Op, Closures(Int8x64k)]
        public static T cell<T>(Span<byte> src)
            where T : unmanaged           
                => read<T>(src);

        /// <summary>
        /// Reads an unmanaged generic value from a bytespan beginning at a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source array offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Int8x64k)]
        public static T cell<T>(Span<byte> src, uint offset)
            where T : unmanaged
                => read<T>(slice(src, offset));
    }
}