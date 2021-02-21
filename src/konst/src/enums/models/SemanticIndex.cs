//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SemanticIndex<K,T> : ISemanticIndex<SemanticIndex<K,T>,K,T>
        where K : unmanaged, Enum
    {
        readonly Type Key;

        readonly Index<T> Storage;

        readonly Index<K> Keys;

        readonly Index<EnumLiteralDetail<K>> _KeyIndex;

        readonly Index<string> _KeyNames;

        readonly ClrEnumKind _KeyKind;

        [MethodImpl(Inline)]
        public SemanticIndex(T[] data)
        {
            Storage = data;
            Key = typeof(K);
            Keys = Enums.literals<K>();
            _KeyIndex = Enums.index<K>().Storage;
            _KeyNames = ClrEnums.names<K>();
            _KeyKind = ClrEnums.@base<K>();
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Storage.View;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Storage.Edit;
        }

        public ref T this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[EnumValue.scalar<K,ushort>(index)];
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => Storage.Count;
        }

        public Type KeyType
        {
            [MethodImpl(Inline)]
            get => Key;
        }

        public ReadOnlySpan<K> KeyValues
        {
            [MethodImpl(Inline)]
            get => Keys.View;
        }

        public ReadOnlySpan<EnumLiteralDetail<K>> KeyIndex
        {
            [MethodImpl(Inline)]
            get => _KeyIndex.View;
        }

        public ReadOnlySpan<string> KeyNames
        {
            [MethodImpl(Inline)]
            get => _KeyNames.View;
        }

        public ClrEnumKind KeyKind
        {
            [MethodImpl(Inline)]
            get => _KeyKind;
        }
    }
}