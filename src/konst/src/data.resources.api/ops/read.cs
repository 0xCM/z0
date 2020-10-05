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

    partial struct Resources
    {
        const int ResLength = 0xA;

        public static void read<E>(ReadOnlySpan<MemoryAddress> src, Span<TextResource<E>> dst)
            where E : unmanaged, Enum
        {
            var count = min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref skip(src,(uint)i);
                var value = z.format(cast<char>(Buffers.view<byte>(address, ResLength)));
                var id = Enums.literal<E,int>(i + 1);
                seek(dst,(uint)i) = Resources.define(id, address, value);
            }
        }
    }
}