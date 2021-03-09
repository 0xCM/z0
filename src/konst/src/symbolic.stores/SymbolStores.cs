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

    [ApiHost(ApiNames.SymbolStores, true)]
    public readonly partial struct SymbolStores
    {
        const NumericKind Closure = UnsignedInts;

#if ABC
        public static Index<Token<E>> tokens<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var details = Enums.details<E,T>().View;
            var count = details.Length;
            var buffer = alloc<Token<E>>(count);
            ref var dst = ref first(buffer);
            for(uint i=1; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var symbol = detail.Field.Tag<SymbolAttribute>().MapValueOrDefault(a => a.Symbol, EmptyString);
                seek(dst,i) = Tokens.token(i, detail.Name, detail.LiteralValue, symbol);
            }
            return buffer;
        }
#endif
        /// <summary>
        /// Creates a symbol index from an unmanaged value sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="S">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<Symbol<S>> symbols<S>(params S[] src)
            where S : unmanaged
                => src.Map(symbol);

        [MethodImpl(Inline), Op]
        static SymbolSet<Symbol<AsciCharCode>,byte,W8> create_symbol_set_example(params AsciCharCode[] src)
            => set<Symbol<AsciCharCode>,byte,W8>(SymbolStores.symbols(src));

    }
}