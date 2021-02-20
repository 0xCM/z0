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
    public readonly struct SymbolName
    {
        readonly ISymbolSet Symbols;

        readonly ushort Index;

        [MethodImpl(Inline)]
        internal SymbolName(ISymbolSet src, ushort index)
        {
            Symbols = src;
            Index = index;
        }
    }
}