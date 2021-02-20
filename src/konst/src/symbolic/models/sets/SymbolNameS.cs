//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines the name of a symbol
    /// </summary>
    public readonly struct SymbolName<S>
        where S : unmanaged
    {
        readonly ISymbolSet<S> Symbols;

        readonly ushort Index;

        [MethodImpl(Inline)]
        internal SymbolName(ISymbolSet<S> src, ushort index)
        {
            Symbols = src;
            Index = index;
        }

        [MethodImpl(Inline)]
        public static implicit operator SymbolName(SymbolName<S> src)
            => new SymbolName(src.Symbols, src.Index);
    }
}