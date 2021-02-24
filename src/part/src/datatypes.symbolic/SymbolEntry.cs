//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymbolEntry<E>
    {
        public uint Index {get;}

        public string Key {get;}

        SymbolicLiteral<E> Value {get;}

        [MethodImpl(Inline)]
        internal SymbolEntry(uint index, SymbolicLiteral<E> value)
        {
            Index = index;
            Key = value.UniqueName;
            Value = value;
        }

        public Name Name
        {
            [MethodImpl(Inline)]
            get => Value.Name;
        }

        public E DirectValue
        {
            [MethodImpl(Inline)]
            get => Value.DirectValue;
        }

        public ulong EncodedValue
        {
            [MethodImpl(Inline)]
            get => Value.EncodedValue;
        }

        public ClrPrimalKind DataType
        {
            [MethodImpl(Inline)]
            get => Value.DataType;
        }
    }
}