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

        [MethodImpl(Inline), Op]
        public unsafe static TextResourceRow row(in TextResource src)
        {
            var dst = new TextResourceRow();
            dst.Id = src.Source.MetadataToken;
            dst.Address = src.Address;
            dst.Value = src.Address.Pointer<char>();
            return dst;
        }

        [MethodImpl(Inline), Op]
        public unsafe static ref TextResourceRow row(in TextResource src, out TextResourceRow dst)
        {
            dst.Id = src.Source.MetadataToken;
            dst.Address = src.Address;
            dst.Value = src.Address.Pointer<char>();
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static TextResourceRows rows(TextResource[] src)
            => src.Select(r => row(r));

        [Op]
        public static TextResource[] text(Type src)
        {
            var values = span(Literals.values2<string>(src));
            var count = values.Length;
            var buffer = alloc<TextResource>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var fv = ref skip(values,i);
                ref var target = ref seek(dst,i);
                target.Address = address(fv.Value);
                target.Source = fv.Field;
                target.Value = fv.Value;
            }
            return buffer;
        }

        // [Op]
        // public static void read(ReadOnlySpan<MemoryAddress> locations, Span<TextResource> dst)
        // {
        //     var count = min(locations.Length, dst.Length);
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var address = ref skip(locations,(uint)i);
        //         var data = Address.view<byte>(address, ResLength);
        //         var content = format(cast<char>(data));
        //         seek(dst, (uint)i) = new TextResource((ulong)address, address, content);
        //     }
        // }

        public static Span<TextResource<E>> text<E>(Type declarer)
            where E : unmanaged, Enum
        {
            var locations = addresses(declarer);
            var count = locations.Length;
            var dst = sys.alloc<TextResource<E>>(count);
            read(locations,span(dst));
            return dst;
        }

        public static void read<E>(ReadOnlySpan<MemoryAddress> locations, Span<TextResource<E>> dst)
            where E : unmanaged, Enum
        {
            var count = min(locations.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref skip(locations,(uint)i);
                var value = format(cast<char>(Address.view<byte>(address, ResLength)));
                var id = Enums.literal<E,int>(i + 1);
                seek(dst,(uint)i) = define(id, address, value);
            }
        }
    }
}