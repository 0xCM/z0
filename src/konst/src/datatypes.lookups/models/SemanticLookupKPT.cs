//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SemanticLookup<K,P,T> : ISemanticLookup<SemanticLookup<K,P,T>,K,P,T>
        where K : unmanaged, Enum
        where P : unmanaged
    {
        /// <summary>
        /// The key's system type
        /// </summary>
        readonly Type keyType;

        /// <summary>
        /// The key's primal type
        /// </summary>
        readonly EnumLiteralKind keyKind;

        /// <summary>
        /// The indexed data
        /// </summary>
        readonly T[] Data;

        readonly EnumLiteralNames<K> nameIndex;

        readonly K[] keys;

        readonly EnumLiteralDetails<K,P> literals;

        readonly EnumLiteralDetail<K,P>[] keyIndex;

        readonly string[] keyNames;

        [MethodImpl(Inline)]
        public SemanticLookup(T[] data)
        {
            Data = data;
            keyType = typeof(K);
            nameIndex = Enums.NameIndex<K>();
            keys = Enums.literals<K>();
            literals = Enums.values<K,P>();
            keyIndex = literals.Storage;
            keyNames = Enums.names<K>();
            keyKind = Enums.kind<K>();
        }

        public ReadOnlySpan<T> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<T> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref T this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Data[EnumValue.scalar<K,ushort>(index)];
        }

        public Count EntryCount
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public Type KeyType
        {
            [MethodImpl(Inline)]
            get => keyType;
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

        public ReadOnlySpan<EnumLiteralDetail<K,P>> KeyIndex
        {
            [MethodImpl(Inline)]
            get => keyIndex;
        }

        public ReadOnlySpan<string> KeyNames
        {
            [MethodImpl(Inline)]
            get => keyNames;
        }

        public EnumLiteralKind KeyKind
        {
            [MethodImpl(Inline)]
            get => keyKind;
        }
    }
}