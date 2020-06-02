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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);
     
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);
             
        /// <summary>
        /// Reimagines a boolean value as a character value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static char character(bool src)
            => (char)(numeric(src) + 48);
    }
}