//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    public readonly struct FieldIndex<I,W> : IFieldIndex<FieldIndexEntry<I,W>>, IFormattable<FieldIndex<I,W>>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
    {
        readonly FieldIndexEntry<I,W>[] entries;        

        [MethodImpl(Inline)]
        public static implicit operator FieldIndex<I,W>(FieldIndexEntry<I,W>[] entries)
            => new FieldIndex<I,W>(entries);

        [MethodImpl(Inline)]
        public static implicit operator FieldIndexEntry<I,W>[](FieldIndex<I,W> src)
            => src.entries;

        [MethodImpl(Inline)]
        internal FieldIndex(FieldIndexEntry<I,W>[] entries)
        {
            this.entries = entries;
        }

        public ReadOnlySpan<FieldIndexEntry<I,W>> Entries
        {
            [MethodImpl(Inline)]
            get => entries;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => entries.Length;
        }

        public ref readonly FieldIndexEntry<I,W> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref entries[Enums.numeric<I,int>(index)];
        }

        public ref readonly FieldIndexEntry<I,W> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref entries[index];
        }

        public string Format()
        {
            var formatter = SpanFormatter.Define<FieldIndexEntry<I,W>>(AsciEscape.Eol);
            return formatter.Format(Entries);
        }

        public override string ToString()
            => Format();
    }        
}