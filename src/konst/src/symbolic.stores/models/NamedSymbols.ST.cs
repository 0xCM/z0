//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Symbolic;

    public readonly struct NamedSymbols<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly SymbolStore<S,T> _Symbols;

        readonly NamedSymbols<S> _Names;

        [MethodImpl(Inline)]
        internal NamedSymbols(SymbolStore<S,T> src, NamedSymbols<S> names)
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

        public SymbolStore<S,T> Symbols
        {
            [MethodImpl(Inline)]
            get => _Symbols;
        }
    }
}