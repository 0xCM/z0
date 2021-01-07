//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SemanticLookup<K,T> : ISemanticIndex<SemanticLookup<K,T>,K,T>
        where K : unmanaged, Enum
    {
        readonly Type Key;

        readonly T[] Storage;

        readonly EnumLiteralNames<K> nameIndex;

        readonly K[] keys;

        readonly EnumLiteralDetail<K>[] keyIndex;

        readonly string[] keyNames;

        readonly ClrEnumKind keyKind;

        [MethodImpl(Inline)]
        public SemanticLookup(T[] data)
        {
            Storage = data;
            Key = typeof(K);
            nameIndex = Enums.NameIndex<K>();
            keys = Enums.literals<K>();
            keyIndex = Enums.index<K>().Content;
            keyNames = Enums.names<K>();
            keyKind = Enums.kind<K>();
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public ref T this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[EnumValue.scalar<K,ushort>(index)];
        }

        public Count EntryCount
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public Type KeyType
        {
            [MethodImpl(Inline)]
            get => Key;
        }

        public EnumLiteralNames<K> KeyNameIndex
        {
            [MethodImpl(Inline)]
            get => nameIndex;
        }

        public ReadOnlySpan<K> KeyValues
        {
            [MethodImpl(Inline)]
            get => keys;
        }

        public ReadOnlySpan<EnumLiteralDetail<K>> KeyIndex
        {
            [MethodImpl(Inline)]
            get => keyIndex;
        }

        public ReadOnlySpan<string> KeyNames
        {
            [MethodImpl(Inline)]
            get => keyNames;
        }

        public ClrEnumKind KeyKind
        {
            [MethodImpl(Inline)]
            get => keyKind;
        }
    }
}