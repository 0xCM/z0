//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Symbolic
    {
        [Op]
        public static void emit(ReadOnlySpan<TokenRecord> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            var header = text.concat($"Identifier".PadRight(20), "| ", "Token".PadRight(20), "| ", "Meaning");
            writer.WriteLine(header);
            for(var i=1; i<count; i++)
            {
                ref readonly var token = ref skip(src,i);
                var line = text.concat(token.Name.Format().PadRight(20), "| ", token.Value.PadRight(20), "| ", token.Description);
                writer.WriteLine(line);
            }
        }

        public static ReadOnlySpan<char> render<K,S>(ReadOnlySpan<Token<K,S>> src, Span<char> dst)
            where K : unmanaged
            where S : unmanaged, ISymbol
        {
            var tokenCount = src.Length;
            for(var i=0u; i<tokenCount; i++)
            {
                var symbols = skip(src,i).Symbols;
                var symbolCount = symbols.Length;
                for(var j=0u; j<symbolCount; j++)
                    seek(dst,i) = render(skip(symbols,i));
            }
            return dst;
        }

        public static ReadOnlySpan<char> render<K,S>(Token<K,S> src, Span<char> dst)
            where K : unmanaged
            where S : unmanaged, ISymbol
        {
            var symbols = src.Symbols;
            var count = symbols.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = render(skip(symbols,i));
            return dst;
        }


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static char render<S>(S src)
            where S : unmanaged
                => (char)@as<S,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> render<S>(Span<S> src)
            where S : unmanaged, ISymbol
        {
            var count = src.Length;
            if(count == 0)
                return default;
            else if(size<S>() == size<char>())
                return cover(@as<S,char>(first(src)), count);
            else
                return render(src, span<char>(count));
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> render<S>(Span<S> src, Span<char> dst)
            where S : unmanaged, ISymbol
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = render(skip(src,i));
            return slice(dst, 0, count);
        }

        [MethodImpl(Inline)]
        public static char render<S,T,N>(Symbol<S,T,N> src)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => render<S>(src.Value);

        [MethodImpl(Inline)]
        public static char render<S,T>(Symbol<S,T> src)
            where S : unmanaged
            where T : unmanaged
                => @as<S,char>(src.Value);
    }
}