//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MemorySymbol : IStoredSymbol<MemorySymbol>
    {
        readonly ISymbolStore SymbolStore;

        public uint SymbolId {get;}

        [MethodImpl(Inline)]
        internal MemorySymbol(ISymbolStore store, uint id)
        {
            SymbolStore = store;
            SymbolId = id;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => SymbolStore is null;
        }

        public string SymbolName
        {
            [MethodImpl(Inline)]
            get => SymbolStore?.SymbolName(SymbolId) ?? EmptyString;
        }

        public static MemorySymbol Empty
        {
            [MethodImpl(Inline)]
            get => new MemorySymbol(null, uint.MaxValue);
        }
    }
}