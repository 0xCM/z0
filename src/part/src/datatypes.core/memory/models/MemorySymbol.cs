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

        public uint Index {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        internal MemorySymbol(IMemorySymbols store, ByteSize size, uint index)
        {
            Store = store;
            Index = index;
            Size = size;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Store is null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public SymExpr Expression
        {
            [MethodImpl(Inline)]
            get => Store?.Expression(Index) ?? SymExpr.Empty;
        }

        public static MemorySymbol Empty
        {
            [MethodImpl(Inline)]
            get => new MemorySymbol(null, 0, 0);
        }
    }
}