//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public partial class Bit
    {
        const NumericKind Closure = UnsignedInts;

        public static bit[] unpack<T>(T src)
            where T : struct
        {
            var buffer = sys.alloc<bit>(bitsize<T>());
            unpack(src, buffer);
            return buffer;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void unpack<T>(in T src, Span<bit> dst)
            where T : struct
        {
            var size = memory.size<T>();
            ref readonly var input = ref memory.uint8(ref edit(src));
            for(var i=0u; i<size; i++)
            {
                ref readonly var b = ref memory.skip(input,i);
                for(byte j=0; j<8; j++)
                    seek(dst,j) = BitStates.test(b,j);
            }
        }

        /// <summary>
        /// Promotes a bit to a numeric value where all target bits are enabled if the state of the
        /// bit is on; otherwise all target bits are disabled
        /// </summary>
        /// <param name="src">The source bit</param>
        /// <typeparam name="T">The target numeric type</typeparam>
        [MethodImpl(Inline), Op]
        public static T promote<T>(bit src)
            where T : unmanaged
                => src? NumericLiterals.maxval<T>() : default;

        /// <summary>
        /// Wraps a bitview around a generic reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The generic type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitEdit<T> editor<T>(in T src)
            where T : unmanaged
                => new BitEdit<T>(src);
    }
}