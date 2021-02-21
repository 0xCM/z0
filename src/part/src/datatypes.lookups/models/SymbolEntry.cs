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

    public readonly struct SymbolEntry<E>
        where E : unmanaged
    {
        public uint Index {get;}

        public string Key {get;}

        public SymbolicLiteral<E> Value {get;}

        [MethodImpl(Inline)]
        public SymbolEntry(uint index, string key, SymbolicLiteral<E> value)
        {
            Index = index;
            Key = key;
            Value = value;
        }

        public Name Name
        {
            [MethodImpl(Inline)]
            get => Value.Name;
        }

        public E Literal
        {
            [MethodImpl(Inline)]
            get => Value.LiteralValue;
        }

        public ulong Scalar
        {
            [MethodImpl(Inline)]
            get => Value.ScalarValue;
        }

        public ClrPrimalKind DataType
        {
            [MethodImpl(Inline)]
            get => Value.DataType;
        }
    }
}