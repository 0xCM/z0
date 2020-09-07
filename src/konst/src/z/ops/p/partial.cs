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
        /// Reads a partial value if there aren't a sufficient number of bytes to comprise a target value
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T partial<T>(Span<byte> src)
            where T : struct
        {
            if(src.Length == 0)
                return default;

            var tSize = size<T>();
            var srclen = src.Length;
            if(srclen >= tSize)
                return read<T>(src);
            else
            {
                var remaining = tSize - srclen;
                var storage = default(T);
                ref var dst = ref @as<T,byte>(storage);
                for(var i=0u; i<srclen; i++)
                    seek(dst,i) = skip(src,i);
                return storage;
            }
        }
    }
}