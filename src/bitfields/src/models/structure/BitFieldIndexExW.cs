//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct BitFieldIndex<E,W> : IBitFieldIndex<BitFieldIndexEntry<E,W>>, ITextual<BitFieldIndex<E,W>>
        where E : unmanaged, Enum
        where W : unmanaged, Enum
    {
        readonly BitFieldIndexEntry<E,W>[] entries;        

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndex<E,W>(BitFieldIndexEntry<E,W>[] entries)
            => new BitFieldIndex<E,W>(entries);

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndexEntry<E,W>[](BitFieldIndex<E,W> src)
            => src.entries;

        [MethodImpl(Inline)]
        internal BitFieldIndex(BitFieldIndexEntry<E,W>[] entries)
        {
            this.entries = entries;
        }

        public ReadOnlySpan<BitFieldIndexEntry<E,W>> Entries
        {
            [MethodImpl(Inline)]
            get => entries;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => entries.Length;
        }

        public ref readonly BitFieldIndexEntry<E,W> this[E index]
        {
            [MethodImpl(Inline)]
            get => ref entries[Enums.scalar<E,int>(index)];
        }

        public ref readonly BitFieldIndexEntry<E,W> this[int index]
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