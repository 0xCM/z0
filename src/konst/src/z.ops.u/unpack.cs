//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static void unpack(byte src, Span<BitState> dst)
            => unpack(src, ref first(dst));

        [MethodImpl(Inline), Op]
        public static ulong unpack(byte src)
        {
            var storage = 0ul;
            ref var dst = ref @as<ulong,BitState>(storage);        
            seek(dst, 0) = test(skip(src, 0), 0);
            seek(dst, 1) = test(skip(src, 1), 1);
            seek(dst, 2) = test(skip(src, 2), 2);
            seek(dst, 3) = test(skip(src, 3), 3);
            seek(dst, 4) = test(skip(src, 4), 4);
            seek(dst, 5) = test(skip(src, 5), 5);
            seek(dst, 6) = test(skip(src, 6), 6);
            seek(dst, 7) = test(skip(src, 7), 7);
            return storage;
        }

        /// <summary>
        /// Populates a caller-supplied target with unpacked source bits
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The data source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void unpack<T>(T src, Span<BitState> dst)
            where T : struct
        {
            var count = size<T>();
            var data = bytes(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var u8 = ref skip(data,i);
                for(byte j=0; j<8; j++)
                    seek(dst, i+j) = test(u8,j);
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref BitState unpack<T>(in T src, ref BitState dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var input = ref @as<T,byte>(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var u8 = ref skip(input,i);
                for(byte j=0; j<8; j++)
                    seek(dst, i+j) = test(u8,j);
            }
            return ref dst;
        }
    }
}