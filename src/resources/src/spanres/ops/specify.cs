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

    partial struct SpanRes
    {
        [MethodImpl(Inline), Op]
        public static ByteSpanSpec specify(Identifier name, BinaryCode data, bool @static = true)
            => new ByteSpanSpec(name, data, @static);

        [MethodImpl(Inline)]
        public static SymSpanSpec<E> specify<E>(Identifier name)
            where E : unmanaged, Enum
                => specify<E>(name, Symbols.index<E>().View);

        [MethodImpl(Inline)]
        public static ByteSpanSpec<T> bytespan<T>(Identifier name, T[] data, bool @static = true)
            where T : unmanaged
                => new ByteSpanSpec<T>(name, data, @static);

        [MethodImpl(Inline)]
        public static CharSpanSpec charspan(Identifier name, string data, bool @static = true)
            => new CharSpanSpec(name, data, @static);

        [MethodImpl(Inline)]
        public static SymSpanSpec<E> specify<E>(Identifier name, ReadOnlySpan<Sym<E>> literals, bool @static = true)
            where E : unmanaged, Enum
                => new SymSpanSpec<E>(name, literals, @static);

        [Op]
        public static ByteSpanSpec specify(OpUri uri, BinaryCode data, bool @static = true)
            => new ByteSpanSpec(LegalIdentityBuilder.code(uri.OpId), data, @static);

        [Op]
        public static ByteSpanSpec merge(Identifier name, ByteSpanSpecs props)
        {
            var buffer = alloc<byte>(props.TotalSize);
            var c0 = props.Count;
            ref var dst = ref first(buffer);
            var view = props.View;
            var k=0;
            for(var i=0; i<c0; i++)
            {
                ref readonly var prop = ref skip(view,i);
                ref readonly var src = ref prop.FirstByte;
                var c1 = prop.Data.Count;
                for(var j=0; j<c1; j++, k++)
                    seek(dst,k) = skip(src,j);
            }
            return specify(name, buffer, props.First.IsStatic);
        }

        public Index<ByteSpanSpec> NameProps<K>(Symbols<K> src)
            where K : unmanaged
        {
            var view = src.View;
            var count = view.Length;
            var buffer = alloc<ByteSpanSpec>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var sym = ref skip(view,i);
                seek(dst,i) = NameProp(sym);
            }
            return buffer;
        }

        public ByteSpanSpec NameProp<K>(Sym<K> src)
            where K : unmanaged
                => SpanRes.specify(src.Name, TextTools.utf16(src.Name).ToArray());
    }
}