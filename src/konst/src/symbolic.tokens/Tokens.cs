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

    [ApiHost]
    public readonly struct Tokens
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Token<K> token<K>(ushort index, Identifier name, K kind, Name symbol)
            where K : unmanaged
                => new Token<K>(index,name,kind,symbol);

        [MethodImpl(Inline)]
        public static Tokens<I,K,S> tokens<I,K,S>(Token<K,S>[] src, I i = default)
            where K : unmanaged
            where S : unmanaged, ISymbol
            where I : unmanaged
                => new Tokens<I,K,S>(src);

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

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public void Symbols<T>(in T src, Span<HexSymLo> dst)
            where T : unmanaged
        {
            ref readonly var b = ref @as<T,byte>(src);
            var cellsize = size<T>();
            for(var i=0u; i<cellsize; i++)
            {
                var symbols = SymbolStores.hex(skip(b,i), LowerCase);
                for(var j=0u; j<cellsize; j++)
                    seek(dst,j) = skip(symbols, j);
            }
        }

        [MethodImpl(Inline)]
        public static KindedIdentity<K,A> identify<K,A>(K kind, A id)
            where K : unmanaged
            where A : unmanaged
                => (kind, id);

        /// <summary>
        /// Defines a <see cref='NamedSymbol{S}'/> sequence
        /// </summary>
        /// <param name="src">The source symbols</param>
        /// <typeparam name="S">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public static NamedSymbols<S> names<S>(params NamedSymbol<S>[] src)
            where S : unmanaged, ISymbol<S>
                => new NamedSymbols<S>(src);

        public static ReadOnlySpan<char> render<K,S>(ReadOnlySpan<Token<K,S>> src, Span<char> dst)
            where K : unmanaged
            where S : unmanaged, ISymbol
        {
            var tokenCount= src.Length;
            for(var i=0u; i<tokenCount; i++)
            {
                var symbols = skip(src,i).Symbols;
                var symbolCount = symbols.Length;
                for(var j=0u; j<symbolCount; j++)
                    seek(dst,i) = Symbolic.render(skip(symbols,i));
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
                seek(dst,i) = Symbolic.render(skip(symbols,i));
            return dst;
        }

        [MethodImpl(Inline)]
        public static TokenSpec<K,S> spec<K,S>(uint index, K kind, string id, params S[] symbols)
            where K : unmanaged
            where S : unmanaged, ISymbol<S>
                => new TokenSpec<K,S>(index, kind, id, symbols);
    }
}