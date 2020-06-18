//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct FieldIndex<E,W> : IFieldIndex<FieldIndexEntry<E,W>>, ITextual<FieldIndex<E,W>>
        where E : unmanaged, Enum
        where W : unmanaged, Enum
    {
        readonly FieldIndexEntry<E,W>[] entries;        

        [MethodImpl(Inline)]
        public static implicit operator FieldIndex<E,W>(FieldIndexEntry<E,W>[] entries)
            => new FieldIndex<E,W>(entries);

        [MethodImpl(Inline)]
        public static implicit operator FieldIndexEntry<E,W>[](FieldIndex<E,W> src)
            => src.entries;

        [MethodImpl(Inline)]
        internal FieldIndex(FieldIndexEntry<E,W>[] entries)
        {
            this.entries = entries;
        }

        public ReadOnlySpan<FieldIndexEntry<E,W>> Entries
        {
            [MethodImpl(Inline)]
            get => entries;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => entries.Length;
        }

        public ref readonly FieldIndexEntry<E,W> this[E index]
        {
            [MethodImpl(Inline)]
            get => ref entries[Enums.scalar<E,int>(index)];
        }

        public ref readonly FieldIndexEntry<E,W> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref entries[index];
        }

        public string Format()
            => Formattable.format(Entries, Chars.Eol);

        public override string ToString()
            => Format();
    }        
}