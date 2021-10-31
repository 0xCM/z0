//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AtomicSeq<K>
        where K : unmanaged
    {
        readonly Index<Atom<K>> Data;

        [MethodImpl(Inline)]
        public AtomicSeq(Atom<K>[] terms)
        {
            Data = terms;
        }

        public AtomicSeq<K> Concat(AtomicSeq<K> src)
            => lang.concat(this, src);

        public ReadOnlySpan<Atom<K>> Members
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ref readonly Atom<K> this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly Atom<K> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        internal Atom<K>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        [MethodImpl(Inline)]
        public static implicit operator AtomicSeq<K>(Atom<K>[] src)
            => new AtomicSeq<K>(src);

        public static AtomicSeq<K> operator+(AtomicSeq<K> a, AtomicSeq<K> b)
            => a.Concat(b);

        public static AtomicSeq<K> Empty
        {
            [MethodImpl(Inline)]
            get => new AtomicSeq<K>(sys.empty<Atom<K>>());
        }
    }
}