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

    partial struct SymbolStore
    {
        [MethodImpl(Inline)]
        public static NamedSymbols<S,T> named<S,T>(S s = default, T t = default)
            where S : unmanaged, Enum
            where T : unmanaged
        {
            var symbols = symbols<S,T>();
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(symbols.Count));
            return new NamedSymbols<S,T>(symbols, names);
        }

        [MethodImpl(Inline)]
        public static NamedSymbols<S,T,N> named<S,T,N>(S s = default, T t = default, N n = default)
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