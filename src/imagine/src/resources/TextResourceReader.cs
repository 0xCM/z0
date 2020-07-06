//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
 
    [ApiHost]
    public readonly struct TextResourceReader : IApiHost<TextResourceReader>
    {
        [MethodImpl(Inline), Op]
        public static MemoryAddress address(string src)
            => Root.locate(As.first(As.span(src)));            

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<MemoryAddress> addresses(Type declarer)
            => LiteralFieldValues.values<string>(declarer).Map(address);

        [MethodImpl(Inline), Op]
        public static int read(ReadOnlySpan<MemoryAddress> locations, Span<TextResource> dst)        
        {            
            var count = Math.Min(locations.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref As.skip(locations,(uint)i);
                var data = Addressable.view<byte>(address, ResLength);
                var content = Render(Symbols(data));
                As.seek(dst, (uint)i) = TextResource.Define((ulong)address, address, content);            
            }
            return count;
        }

        [Op]
        public static Span<TextResource> read(Type declarer)
        {
            var locations = addresses(declarer);
            var count = locations.Length;
            var dst = sys.alloc<TextResource>(count);
            read(locations, dst);
            return dst;
        }

        public static Span<TextResource<E>> read<E>(Type declarer)
            where E : unmanaged, Enum
        {
            var locations = addresses(declarer);
            var count = locations.Length;
            var dst = Root.span(sys.alloc<TextResource<E>>(count));
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref As.skip(locations,(uint)i);
                var value = Spans.cast<char>(Addressable.view<byte>(address, ResLength)).ToString();
                var id = EnumValue.literal<E,int>(i + 1);
                As.seek(dst,(uint)i) = TextResource.Define(id, address, value);            
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