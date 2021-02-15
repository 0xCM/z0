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
    public readonly struct SymbolName<K>
        where K : unmanaged
    {
        readonly ISymbolSet<K> Symbols;

        readonly ushort Index;

        [MethodImpl(Inline)]
        internal SymbolName(ISymbolSet<K> src, ushort index)
        {
            Symbols = src;
            Index = index;
        }

        // [MethodImpl(Inline)]
        // public string Format()
        //     => Symbols[Index].Name;

        // public override string ToString()
        //     => Format();
    }
}