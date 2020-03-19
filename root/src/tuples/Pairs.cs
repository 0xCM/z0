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

    using static Root;

    public static class Pairs
    {
        public static Pairs<T> alloc<T>(int count)
            where T : unmanaged
                => new Pairs<T>(new Pair<T>[count]);
    }

    public static class PairEval
    {
        [MethodImpl(Inline)]
        public static PairEval<T> Define<T>(in Pairs<T> src, in Triples<T> dst)
            where T : unmanaged
                => new PairEval<T>(src,dst);
    }

    public readonly ref struct PairEval<T>
        where T : unmanaged
    {
        public readonly Pairs<T> Source;

        public readonly Triples<T> Target;        
        
        [MethodImpl(Inline)]
        public PairEval(in Pairs<T> src, in Triples<T> dst)
        {
            this.Source = src;
            this.Target = dst;
        }        
    }

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
            => ref seek(Data, index);

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