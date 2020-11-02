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

    [ApiHost]
    public readonly struct Tokens
    {
        [MethodImpl(Inline)]
        public void Symbols<T>(in T src, Span<HexSymLo> dst)
            where T : unmanaged
        {
            ref readonly var b = ref @as<T,byte>(src);
            var cellsize = size<T>();
            for(var i=0u; i<cellsize; i++)
            {
                var symbols = SymbolStore.hex(skip(b,i), LowerCase);
                for(var j=0u; j<cellsize; j++)
                    seek(dst,j) = skip(symbols, j);
            }
        }

        [MethodImpl(Inline)]
        public static ArtifactIdentity<K,A> identify<K,A>(K kind, A id)
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
        public static TokenRecord token<T>(T index, string id, string value, string description)
            where T : unmanaged, Enum
                => new TokenRecord(EnumValue.e32u(index), id, value, description);
    }
}