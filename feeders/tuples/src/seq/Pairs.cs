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

    public readonly ref struct Pairs<T>
        where T : unmanaged
    {
        readonly Span<Pair<T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator Pairs<T>(Span<Pair<T>> src)
            => new Pairs<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Pairs<T>(Pair<T>[] src)
            => new Pairs<T>(src);

        [MethodImpl(Inline)]
        public Pairs(Span<Pair<T>> data)
        {
            this.Data = data;
        }

        [MethodImpl(Inline)]
        public ref Pair<T> Select(int index)
            => ref refs.seek(Data, index);

        public ref Pair<T> this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Select(index);
        }        

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public IEnumerable<Pair<T>> Enumerate()
            => Data.ToEnumerable();
    }
}