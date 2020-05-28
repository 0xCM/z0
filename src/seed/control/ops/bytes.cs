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
        public static ReadOnlySpan<byte> bytes<T>(in T src)
            where T : struct
                => MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref edit(src), 1));

        /// <summary>
        /// Tests the state of an index-identified source bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline)]
        public static bool testbit(byte src, int pos)
            => ((src >> pos) & 1) != 0;
        
        /// <summary>
        /// Reimagines a boolean value as a numeric value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte numeric(bool src)
            => *((byte*)(&src));

        /// <summary>
        /// Reimagines a boolean value as a character value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static char character(bool src)
            => (char)(numeric(src) + 48);

    }
}