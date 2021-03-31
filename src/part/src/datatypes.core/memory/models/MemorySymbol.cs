//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MemorySymbol
    {
        readonly IMemorySymbols Store;

        public uint SymbolId {get;}

        [MethodImpl(Inline)]
        internal MemorySymbol(IMemorySymbols store, uint id)
        {
            Store = store;
            SymbolId = id;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Store is null;
        }

        public string SymbolName
        {
            [MethodImpl(Inline)]
            get => Store?.SymbolName(SymbolId) ?? EmptyString;
        }

        public static MemorySymbol Empty
        {
            [MethodImpl(Inline)]
            get => new MemorySymbol(null, uint.MaxValue);
        }
    }
}