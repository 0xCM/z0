//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct RecordFields
    {
        readonly IndexedSeq<RecordField> Data;

        [MethodImpl(Inline)]
        public static implicit operator RecordFields(RecordField[] src)
            => new RecordFields(src);

        [MethodImpl(Inline)]
        public RecordFields(RecordField[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref RecordField this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref RecordField this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<RecordField> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<RecordField> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public RecordField[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public static RecordFields Empty
            => new RecordFields(sys.empty<RecordField>());

        [MethodImpl(Inline)]
        public RecordFields Refresh(RecordField[] src)
            => src;
    }
}