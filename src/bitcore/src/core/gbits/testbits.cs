//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class gbits
    {
        /// <summary>
        /// Constructs a bitsequence by interrogating the source with bit state tests
        /// and populates a caller-supplied target with the result
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> testbits<T>(T src, Span<byte> dst, int offset = 0)
            where T : unmanaged
        {
            var n = bitwidth<T>();
            ref var loc = ref seek(first(dst), offset);

            for(var i=0; i<n; i++)
                seek(loc, i) = (byte)testbit(src, (byte)i);
            return dst;
        }

        /// <summary>
        /// Calculates a bit sequence and populates an allocated target with the result
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<byte> testbits<T>(T src)
            where T : unmanaged
        {
            Span<byte> dst = new byte[bitwidth<T>()];
            testbits(src,dst);
            return dst;
        }
    }
}