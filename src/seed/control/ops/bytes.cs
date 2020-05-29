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

    using ByteSpan = System.ReadOnlySpan<byte>;

    partial class Control
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ByteSpan bytes<T>(in T src)
            where T : struct
                => MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref edit(src), 1));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref readonly ByteSpan bytes<T>(in T src, out ByteSpan dst)
            where T : struct
        {
            dst = MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref edit(src), 1));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ByteSpan bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,byte>(src);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => cast<T,byte>(src);

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