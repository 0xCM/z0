//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Tuples;

    public static class Triples
    {
        public static Triples<T> alloc<T>(int count)
            where T : unmanaged
                => new Triples<T>(new Triple<T>[count]);
    }

    public readonly ref struct Triples<T>
        where T : unmanaged
    {
        readonly Span<Triple<T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator Triples<T>(Span<Triple<T>> src)
            => new Triples<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Triples<T>(Triple<T>[] src)
            => new Triples<T>(src);

        [MethodImpl(Inline)]
        public Triples(Span<Triple<T>> data)
        {
            this.Data = data;
        }

        [MethodImpl(Inline)]
        public ref Triple<T> Select(int index)
            => ref refs.seek(Data, index);

        public ref Triple<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Select(index);
        }        

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public IEnumerable<Triple<T>> Enumerate()
            => Data.ToEnumerable();
    }
}