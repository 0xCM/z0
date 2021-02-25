//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Symbolic
    {
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
    }
}