//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static memory;

    public readonly struct EnumSymbols
    {
        public static Table<E> table<E>()
            where E : unmanaged, Enum
        {
            var literals = ClrPrimitives.enums<E>();
            var view = literals.View;
            var count = view.Length;
            var entries = memory.alloc<Entry<E>>(count);
            ref var entry = ref memory.first(entries);
            var index = new Dictionary<string,Entry<E>>(count);
            for(var i=0u; i<count; i++)
            {
                ref readonly var literal = ref skip(view, i);
                seek(entry, i) = define(i, literal);
                index.Add(literal.Name, skip(entry, i));
            }
            return new Table<E>(entries, index);
        }

        public readonly struct Entry<E>
            where E : unmanaged, Enum
        {
            public uint Index {get;}

            public string Key {get;}

            public EnumLiteral<E> Value {get;}

            [MethodImpl(Inline)]
            public Entry(uint index, string key, EnumLiteral<E> value)
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

            public ClrEnumCode DataType
            {
                [MethodImpl(Inline)]
                get => Value.DataType;
            }
        }

        public readonly struct Table<E>
            where E : unmanaged, Enum
        {
            readonly Index<Entry<E>> Data;

            readonly Dictionary<string,Entry<E>> Keys;

            internal Table(Index<Entry<E>> src, Dictionary<string,Entry<E>> keys)
            {
                Data = src;
                Keys = keys;
            }

            [MethodImpl(Inline)]
            public bool Contains(Name symbol)
                => Keys.ContainsKey(symbol);

            [MethodImpl(Inline)]
            public bool Index(Name symbol, out uint index)
            {
                if(Keys.TryGetValue(symbol, out var entry))
                {
                    index = entry.Index;
                    return true;
                }
                index = uint.MaxValue;
                return false;
            }

            [MethodImpl(Inline)]
            public ref readonly Entry<E> Entry(uint index)
                => ref Data[index];

            public ReadOnlySpan<Entry<E>> Entries
            {
                [MethodImpl(Inline)]
                get => Data.View;
            }

            public uint EntryCount
            {
                [MethodImpl(Inline)]
                get => Data.Count;
            }
        }

        [MethodImpl(Inline)]
        static Entry<E> define<E>(uint index, EnumLiteral<E> src)
            where E : unmanaged, Enum
                => new Entry<E>(index, src.Name, src);
    }

}