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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void symbols<T>(in T src, Span<HexSymLo> dst)
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
        public static TokenSpec<K,S> token<K,S>(uint index, K kind, string id, params S[] symbols)
            where K : unmanaged
            where S : unmanaged, ISymbol<S>
                => new TokenSpec<K,S>(index, kind, id, symbols);

        /// <summary>
        /// Creates a symbol index from an unmanaged value sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="S">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<Symbol<S>> symbols<S>(params S[] src)
            where S : unmanaged
                => src.Map(symbol);
    }
}