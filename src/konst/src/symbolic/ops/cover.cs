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

    partial struct Symbolic
    {
        [MethodImpl(Inline)]
        public static Symbolic<S> cover<S>(S s = default)
            where S : unmanaged, Enum
        {
            var symbols = enumerate<S>();
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(symbols.Count));
            return new Symbolic<S>(symbols, names);
        }

        [MethodImpl(Inline)]
        public static Symbolic<S,T> cover<S,T>(S s = default, T t = default)
            where S : unmanaged, Enum
            where T : unmanaged
        {
            var symbols = enumerate<S,T>();
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(symbols.Count));
            return new Symbolic<S,T>(symbols, names);
        }

        [MethodImpl(Inline)]
        public static Symbolic<S,T,N> cover<S,T,N>(S s = default, T t = default, N n = default)
            where S : unmanaged, Enum
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            var symbols = enumerate<S,T,N>();
            var names = new NamedSymbols<S>(alloc<NamedSymbol<S>>(symbols.Count));
            return new Symbolic<S,T,N>(symbols, names);
        }
    }
}