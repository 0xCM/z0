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

    public readonly struct Symbolic<S>
        where S : unmanaged
    {
        readonly Symbols<S> _Symbols;

        readonly NamedSymbols<S> _Names;

        [MethodImpl(Inline)]
        internal Symbolic(Symbols<S> src, NamedSymbols<S> names)
        {
            _Symbols = src;
            _Names = names;
        }

        [MethodImpl(Inline)]
        public char Char(Symbol<S> src)
            => api.@char(src);

        /// <summary>
        /// Assigns a name to a symbol
        /// </summary>
        /// <param name="symbol">The target symbol</param>
        /// <param name="name">The name to assign</param>
        /// <typeparam name="S">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public NamedSymbol<S> Name(S symbol, string name)
            => new NamedSymbol<S>(symbol, name);

        /// <summary>
        /// Retrieves the nonempty symbol names
        /// </summary>
        public NamedSymbols<S> Named
        {
            [MethodImpl(Inline)]
            get => _Names.Storage.Where(x => x.IsNonEmpty);
        }

        public Symbols<S> Symbols
        {
            [MethodImpl(Inline)]
            get => _Symbols;
        }
    }
}