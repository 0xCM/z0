//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AsInternal;
 
    [ApiHost]
    public readonly struct TextResourceReader : IApiHost<TextResourceReader>
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(string src)
            => Addresses.locate(As.first(Root.span(src)));            

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MemoryAddress> addresses(Type declarer)
            => LiteralFieldValues.values<string>(declarer).Map(address);

        [MethodImpl(Inline), Op]
        public static int read(ReadOnlySpan<MemoryAddress> locations, Span<TextResource> dst)        
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
        public static Span<TextResource> read(Type declarer)
        {
            var locations = addresses(declarer);
            var count = locations.Length;
            var dst = Root.alloc<TextResource>(count);
            read(locations, dst);
            return dst;
        }

        public static Span<TextResource<E>> read<E>(Type declarer)
            where E : unmanaged, Enum
        {
            var locations = addresses(declarer);
            var count = locations.Length;
            var dst = Root.span(Root.alloc<TextResource<E>>(count));
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref skip(locations,i);
                var value = Spans.cast<char>(Addresses.read<byte>(address, ResLength)).ToString();
                var id = EnumValue.literal<E,int>(i + 1);
                seek(dst,i) = TextResource.Define(id, address, value);            
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