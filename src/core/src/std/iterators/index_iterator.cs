//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.std
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct iterator
    {
        [MethodImpl(Inline)]
        public static index_iterator<T> begin<T>(Index<T> src)
            => new index_iterator<T>(src,0, src.Length);

        [MethodImpl(Inline)]
        public static index_iterator<I,T> begin<I,T>(Index<I,T> src)
            where I : unmanaged
                => new index_iterator<I,T>(src,0, src.Length);
    }

    public struct index_iterator<T> : iterator<T>
    {
        long Pos;

        long Max;

        Index<T> Source;

        [MethodImpl(Inline)]
        internal index_iterator(Index<T> src, long min, long max)
        {
            Source = src;
            Pos = min;
            Max = max;
        }

        [MethodImpl(Inline)]
        public bool next(out T dst)
        {
            var finished = Pos == Max;
            if(!finished)
                dst = Source[Pos++];
            else
                dst = default;
            return finished;
        }
    }

    public struct index_iterator<I,T> : iterator<I,T>
        where I : unmanaged
    {
        long Pos;

        long Max;

        Index<I,T> Source;

        [MethodImpl(Inline)]
        internal index_iterator(Index<I,T> src, long min, long max)
        {
            Source = src;
            Pos = min;
            Max = max;
        }

        [MethodImpl(Inline)]
        internal index_iterator(Index<I,T> src, I min, I max)
        {
            Source = src;
            Pos = core.bw64i(min);
            Max = core.bw64i(max);
        }

        [MethodImpl(Inline)]
        public bool next(out T dst)
        {
            var finished = Pos == Max;
            if(!finished)
                dst = Source[(core.@as<long,I>(Pos++))];
            else
                dst = default;
            return finished;
        }
    }
}