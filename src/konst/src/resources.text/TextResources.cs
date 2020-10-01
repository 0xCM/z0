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

    [ApiHost(ApiNames.TextResources)]
    public readonly struct TextResources
    {
        const int ResLength = 0xA;

        [MethodImpl(Inline), Op]
        public unsafe static TextResourceRow row(in TextResource src)
        {
            var dst = new TextResourceRow();
            dst.Id = src.Source.MetadataToken;
            dst.Address = src.Address;
            dst.Length = (uint)src.Value.Length;
            return dst;
        }

        [MethodImpl(Inline), Op]
        public unsafe static ref TextResourceRow row(in TextResource src, out TextResourceRow dst)
        {
            dst.Id = src.Source.MetadataToken;
            dst.Address = src.Address;
            dst.Length = (uint)src.Value.Length;
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static string format(in TextResourceRow src)
            => text.format(TextResourceRow.RenderPattern, src.Id, src.Address, z.format(data(src)));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> data(in TextResourceRow src)
            => Address.view<char>(src.Address, src.Length);

        [MethodImpl(Inline), Op]
        public static TextResourceRows rows(TextResource[] src)
            => src.Select(r => row(r));

        [Op]
        public static TextResource[] from(Type src)
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

        public static Span<TextResource<E>> from<E>(Type src)
            where E : unmanaged, Enum
        {
            var locations = Resources.addresses(src);
            var count = locations.Length;
            var dst = span<TextResource<E>>(count);
            read(locations, dst);
            return dst;
        }

        /// <summary>
        /// Creates an asci resource
        /// </summary>
        /// <param name="name">The resource name</param>
        /// <param name="content">The resource data</param>
        /// <param name="description">The resource description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        public static AsciResource<A> asci<A>(asci32 name, A content, asci64? description = null)
            where A : IBytes
                => new AsciResource<A>(name, content, description);

        [MethodImpl(Inline)]
        public static TextResource<E> define<E>(E id, MemoryAddress location, string value)
            where E : unmanaged, Enum
                => new TextResource<E>(id,location,value);

        public static void read<E>(ReadOnlySpan<MemoryAddress> locations, Span<TextResource<E>> dst)
            where E : unmanaged, Enum
        {
            var count = min(locations.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref skip(locations,(uint)i);
                var value = z.format(cast<char>(Address.view<byte>(address, ResLength)));
                var id = Enums.literal<E,int>(i + 1);
                seek(dst,(uint)i) = define(id, address, value);
            }
        }
    }
}