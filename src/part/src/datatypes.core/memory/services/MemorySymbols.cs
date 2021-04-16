//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public class MemorySymbols : IMemorySymbols
    {
        public static MemorySymbols alloc(uint capacity)
            => new MemorySymbols(capacity);

        public static MemorySymbols alloc(int capacity)
            => new MemorySymbols((uint)capacity);

        Index<MemoryAddress> _Addresses;

        Index<SymExpr> _Expressions;

        Index<MemorySymbol> _Deposited;

        Index<AddressHash> _Hashed;

        uint CurrentIndex;

        uint Capacity;

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => CurrentIndex;
        }

        public ReadOnlySpan<MemoryAddress> Addresses
        {
            [MethodImpl(Inline)]
            get => slice(_Addresses.View,0,EntryCount);
        }

        public ReadOnlySpan<MemorySymbol> Deposited
        {
            [MethodImpl(Inline)]
            get => slice(_Deposited.View,0, EntryCount);
        }

        public ReadOnlySpan<SymExpr> Expressions
        {
            [MethodImpl(Inline)]
            get => slice(_Expressions.View,0, EntryCount);
        }

        MemorySymbols(uint count)
        {
            Capacity = count;
            _Addresses = alloc<MemoryAddress>(count);
            _Expressions = alloc<SymExpr>(count);
            _Deposited = alloc<MemorySymbol>(count);
            CurrentIndex = 0;
            _Hashed = sys.empty<AddressHash>();
        }

        [MethodImpl(Inline), Op]
        public bool IsDefined(uint index)
            => (index < Capacity - 1) && _Deposited[index].IsNonEmpty;

        [MethodImpl(Inline), Op]
        public SymExpr Expression(uint index)
            => index < Capacity-1 ? _Expressions[index] : SymExpr.Empty;

        [Op]
        public MemorySymbol Deposit(MemoryAddress address, ByteSize size, SymExpr expr)
        {
            if(CurrentIndex < Capacity - 1)
            {
                _Addresses[CurrentIndex] = address;
                _Expressions[CurrentIndex] = expr;
                var deposited = new MemorySymbol(this, size, CurrentIndex);
                _Deposited[CurrentIndex] = deposited;
                CurrentIndex++;
                return deposited;
            }
            else
                return MemorySymbol.Empty;
        }

        public ReadOnlySpan<AddressHash> Seal()
        {
            if(_Hashed.IsEmpty)
            {
                var src = Addresses;
                var count = (uint)src.Length;
                _Hashed = alloc<AddressHash>(count);
                var dst = _Hashed.Edit;
                memory.hash(src, dst);
            }
            return _Hashed;
        }
    }
}