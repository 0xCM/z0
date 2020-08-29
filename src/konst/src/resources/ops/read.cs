//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct Resources
    {
        const int ResLength = 0xA;

        [Op]
        public static Span<TextResource> read(Type declarer)
        {
            var locations = Resources.addresses(declarer);
            var count = locations.Length;
            var dst = sys.alloc<TextResource>(count);
            Address.read(locations, dst);
            return dst;
        }

        public static Span<TextResource<E>> read<E>(Type declarer)
            where E : unmanaged, Enum
        {
            var locations = addresses(declarer);
            var count = locations.Length;
            var dst = span(sys.alloc<TextResource<E>>(count));
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref skip(locations,(uint)i);
                var value = Spans.cast<char>(Address.view<byte>(address, ResLength)).ToString();
                var id = EnumValue.literal<E,int>(i + 1);
                seek(dst,(uint)i) = TextResource.Define(id, address, value);
            }
            return dst;
        }
    }
}