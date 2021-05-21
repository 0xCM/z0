//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct ApiExtracts
    {
        [MethodImpl(Inline), Op]
        internal static unsafe int read(ref byte* pSrc, int count, Span<byte> dst)
            => read(ref pSrc, count, ref first(dst));

        [MethodImpl(Inline), Op]
        internal static unsafe int read(ref byte* pSrc, int limit, ref byte dst)
        {
            var offset = 0;
            var count = 0;
            while(offset<limit && count<MaxZeroCount)
            {
                var value = Unsafe.Read<byte>(pSrc++);
                seek(dst, offset++) = value;
                if(value != 0)
                    count = 0;
                else
                    count++;
            }
            return offset;
        }
    }
}