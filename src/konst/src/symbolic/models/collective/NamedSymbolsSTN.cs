//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NamedSymbols<S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly SymbolStore<S,T,N> _Symbols;

        readonly NamedSymbols<S> _Names;

        [MethodImpl(Inline)]
        internal NamedSymbols(SymbolStore<S,T,N> src, NamedSymbols<S> names)
        {
            _Symbols = src;
            _Names = names;
        }

        /// <summary>
        /// Retrieves the nonempty symbol names
        /// </summary>
        public NamedSymbols<S> Named
        {
            [MethodImpl(Inline)]
            get => _Names.Storage.Where(x => x.IsNonEmpty);
        }

        public SymbolStore<S,T,N> Symbols
        {
            [MethodImpl(Inline)]
            get => _Symbols;
        }
    }
}