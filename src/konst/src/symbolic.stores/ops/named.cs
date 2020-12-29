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

    partial struct SymbolStore
    {
        [MethodImpl(Inline)]
        public static NamedSymbols<S,T> named<S,T>()
            where S : unmanaged, Enum
            where T : unmanaged
                => named(symbols<S,T>());

        [MethodImpl(Inline)]
        public static NamedSymbols<S,T> named<S,T>(in SymbolStore<S,T> src)
            where S : unmanaged
            where T : unmanaged
        {
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(src.Count));
            return new NamedSymbols<S,T>(src, names);
        }

        [MethodImpl(Inline)]
        public static NamedSymbols<S,T,N> named<S,T,N>()
            where S : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var symbols = symbols<S,T,N>();
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(symbols.Count));
            return new NamedSymbols<S,T,N>(symbols, names);
        }
    }
}