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

        /// <summary>
        /// Defines a <see cref='NamedSymbol{S}'/> sequence
        /// </summary>
        /// <param name="src">The source symbols</param>
        /// <typeparam name="S">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public static NamedSymbols<S> names<S>(params NamedSymbol<S>[] src)
            where S : unmanaged, ISymbol<S>
                => new NamedSymbols<S>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolName<S> name<S>(ISymbolSet<S> src, ushort index)
            where S : unmanaged
                => new SymbolName<S>(src,index);

        [MethodImpl(Inline), Op]
        public static SymbolName name(ISymbolSet src, ushort index)
            => new SymbolName(src,index);

        public static Identifier name<S>(ISymbol<S> src)
            where S : unmanaged
                => src.Value is Enum e ? e.ToString("g") : src.Value.ToString();

        public static Identifier name<K,S>(IKindedSymbol<K,S> src)
            where K : unmanaged
            where S : unmanaged
                => src.Kind is Enum e ? e.ToString("g") : src.Kind.ToString();

        [MethodImpl(Inline)]
        public static TokenSpec<K,S> token<K,S>(uint index, K kind, string id, params S[] symbols)
            where K : unmanaged
            where S : unmanaged, ISymbol<S>
                => new TokenSpec<K,S>(index, kind, id, symbols);

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

        /// <summary>
        /// Defines a symbol set
        /// </summary>
        /// <param name="symbols"></param>
        /// <typeparam name="S">The symbol data type</typeparam>
        /// <typeparam name="T">The symbol domain type</typeparam>
        /// <typeparam name="W">The symbol bit-width type</typeparam>
        [MethodImpl(Inline)]
        public static SymbolSet<S,T,W> set<S,T,W>(params S[] symbols)
            where S : unmanaged, ISymbol
            where T : unmanaged
            where W : unmanaged, IDataWidth
                => new SymbolSet<S,T,W>(symbols);

        /// <summary>
        /// Creates a symbol from an unmanaged value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Symbol<S> symbol<S>(S src)
            where S : unmanaged
                => new Symbol<S>(src);

        /// <summary>
        /// Creates a symbol index from an unmanaged value sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="S">The source element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<Symbol<S>> symbols<S>(params S[] src)
            where S : unmanaged
                => src.Map(symbol);

        /// <summary>
        /// Creates a symbol from an unmanaged value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static Symbol<S,T> symbol<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
                => new Symbol<S,T>(src);

        /// <summary>
        /// Defines an <typeparamref name='S'/>-valued symbol of representation bit-width <typeparamref name='N'/>  covered by a <see cref='T'/> storage cell
        /// </summary>
        /// <param name="value">The symbol value</param>
        /// <typeparam name="S">The symbol type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        /// <typeparam name="N">The symbol representation bit-width</typeparam>
        [MethodImpl(Inline)]
        public static Symbol<S,T,N> symbol<S,T,N>(S value)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Symbol<S,T,N>(value);

        [MethodImpl(Inline)]
        public static NamedSymbols<S,T,N> named<S,T,N>()
            where S : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var symbols = create<S,T,N>();
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(symbols.Count));
            return new NamedSymbols<S,T,N>(symbols, names);
        }

        [MethodImpl(Inline)]
        public static NamedSymbols<S,T> named<S,T>()
            where S : unmanaged, Enum
            where T : unmanaged
                => named(create<S,T>());

        [MethodImpl(Inline)]
        public static NamedSymbols<S,T> named<S,T>(in SymbolStore<S,T> src)
            where S : unmanaged
            where T : unmanaged
        {
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(src.Count));
            return new NamedSymbols<S,T>(src, names);
        }

        /// <summary>
        /// Defines a sequence of symbols predicated on parametric arguments
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="N"></typeparam>
        public static SymbolStore<E,T,N> create<E,T,N>()
            where E : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => create<E,T,N>(Enums.literals<E>());

        [MethodImpl(Inline)]
        public static SymbolStore<E,T,N> create<E,T,N>(E[] src)
            where E : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new SymbolStore<E,T,N>(src.Map(e => symbol<E,T,N>(e)));

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static SymbolStore<E,T> create<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => create<E,T>(Enums.literals<E>());

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static SymbolStore<E,T> create<E,T>(E[] src)
            where E : unmanaged, Enum
            where T : unmanaged
                => new SymbolStore<E,T>(src.Map(x => symbol<E,T>(x)));

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        public static SymbolStore<E> create<E>()
            where E : unmanaged, Enum
                => create<E>(Enums.literals<E>());

        /// <summary>
        /// Creates a symbol store predicated on enumeration literals
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<E> create<E>(E[] src)
            where E : unmanaged
                => new SymbolStore<E>(src.Map(x => symbol<E>(x)));
    }
}