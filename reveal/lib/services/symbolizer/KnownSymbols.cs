//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using static zfunc;
    using Iced.Intel;

    /// <summary>
    /// The symbolizer code is based on code extraced from https://github.com/0xd4d/JitDasm/tree/master/JitDasm; see license file
    /// </summary>
    partial class Symbolizer
    {
        public sealed class KnownSymbols 
        {
            readonly Dictionary<ulong, SymbolResult> symbols = new Dictionary<ulong, SymbolResult>();
            readonly HashSet<ulong> noSymbolAddress = new HashSet<ulong>();

            public void Add(ulong address, SymbolResult symbol) {
                Debug.Assert(!noSymbolAddress.Contains(address));
                symbols.Add(address, symbol);
            }

            public void Bad(ulong address) {
                Debug.Assert(!symbols.ContainsKey(address));
                noSymbolAddress.Add(address);
            }

            public bool IsBadOrKnownSymbol(ulong address) =>
                symbols.ContainsKey(address) || noSymbolAddress.Contains(address);

            public bool TryGetSymbol(ulong address, out SymbolResult result) =>
                symbols.TryGetValue(address, out result);
        }

    }
}