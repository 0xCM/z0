//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitFields
    {
        [MethodImpl(Inline), Op]
        public static string format(ReadOnlySpan<BitFieldSegment> src)
            => BitFieldModels.format(src);

        public static string format<F>(F src)
            where F : unmanaged, IBitFieldIndexEntry<F>
                => BitFieldFormatter.format(src);

        public static string format<W>(in BitFieldIndexEntry<W> src)
            where W : unmanaged, Enum
                => BitFieldFormatter.format(src);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src)
            where E : unmanaged, Enum
            where T : unmanaged
                => BitFieldFormatter.format<E,T>(src);

        /// <summary>
        /// Computes the canonical format for a contiguous field segment sequence
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <typeparam name="T">The type over which the segment is defined</typeparam>
        public static string format<S,T>(ReadOnlySpan<S> src)
            where T : unmanaged
            where S : IBitFieldSegment<T>
                => BitFieldModels.format<S,T>(src);
    }
}