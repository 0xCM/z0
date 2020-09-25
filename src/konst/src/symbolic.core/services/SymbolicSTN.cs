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

    public readonly struct Symbolic<S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        readonly Symbols<S,T,N> _Symbols;

        readonly NamedSymbols<S> _Names;

        [MethodImpl(Inline)]
        internal Symbolic(Symbols<S,T,N> src, NamedSymbols<S> names)
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

        public Symbols<S,T,N> Symbols
        {
            [MethodImpl(Inline)]
            get => _Symbols;
        }
    }
}