//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
 
    [ApiHost]
    public readonly struct TextResourceReader : IApiHost<TextResourceReader>
    {
        static LiteralFieldReader FieldReader => LiteralFieldReader.Service;

        [MethodImpl(Inline), Op]
        public static MemoryAddress ResAddress(string src)
            => location(head(span(src)));            

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MemoryAddress> Locations(Type declarer)
            => FieldReader.Values<string>(declarer).Map(ResAddress);

        [MethodImpl(Inline), Op]
        public static int Read(ReadOnlySpan<MemoryAddress> locations, Span<TextResource> dst)        
        {            
            var count = Math.Min(locations.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref skip(locations,i);
                var data = Addresses.read<byte>(address, ResLength);
                var content = Render(Symbols(data));
                seek(dst, i) = TextResource.Define((ulong)address, address, content);            
            }
            return count;
        }

        [Op]
        public static Span<TextResource> Read(Type declarer)
        {
            var locations = Locations(declarer);
            var count = locations.Length;
            var dst = Spans.alloc<TextResource>(count);
            Read(locations, dst);
            return dst;
        }

        public static Span<TextResource<E>> Read<E>(Type declarer)
            where E : unmanaged, Enum
        {
            var locations = Locations(declarer);
            var count = locations.Length;
            var dst = Spans.alloc<TextResource<E>>(count);
            for(var i=0; i<count; i++)
            {
                var address = locations[i];
                var value = Spans.cast<char>(Addresses.read<byte>(address, ResLength)).ToString();
                var id = Enums.literal<E,int>(i + 1);
                dst[i] = TextResource.Define(id, address, value);            
            }
            return dst;
        }

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> Symbols(ReadOnlySpan<byte> src)
            => Spans.cast<char>(src);

        [MethodImpl(Inline), Op]
        static string Render(ReadOnlySpan<char> src)
            => new string(src);

        const int ResLength = 0xA;
    }
}