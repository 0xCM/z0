//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct HashFunctions
    {
        public static StringHash strings()
            => default(StringHash);

        public static uint collisions<S,T>(Index<S> src, IHashFunction<S,T> hash)
            where T : unmanaged
        {
            var accumulator = root.hashset<T>();
            var count = src.Count;
            var view = src.View;
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(view,i);
                var computed = hash.Compute(input);
                accumulator.Add(computed);
            }

            return count - (uint)accumulator.Count;
        }

        public static HashedIndex<T> perfect<T>(ReadOnlySpan<T> src)
            where T : ITextual
        {
            var count = src.Length;
            var buffer = alloc<HashCode<T>>(count);
            ref var dst = ref first(buffer);
            var accumulator = root.hashset<uint>();
            var algorithm = strings();
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                var computed = algorithm.Compute(input.Format());
                seek(dst,i) = (input,computed);
                accumulator.Add(computed);
            }
            var collisions = count - (uint)accumulator.Count;
            if(collisions != 0)
                root.@throw("Imperfect");
            return new HashedIndex<T>(buffer, t => algorithm.Compute(t.Format()));
        }

        public static HashedIndex<T> perfect<T>(Span<T> src)
            where T : ITextual
                => perfect(src.ReadOnly());

        public static HashedIndex<T> perfect<T>(ReadOnlySpan<T> src, Func<T,string> rep)
        {
            var count = src.Length;
            var buffer = alloc<HashCode<T>>(count);
            ref var dst = ref first(buffer);
            var accumulator = root.hashset<uint>();
            var algorithm = strings();
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                var computed = algorithm.Compute(rep(input));
                seek(dst,i) = (input,computed);
                accumulator.Add(computed);
            }
            var collisions = count - (uint)accumulator.Count;
            if(collisions != 0)
                root.@throw("Imperfect");
            return new HashedIndex<T>(buffer, t => algorithm.Compute(rep(t)));
        }
    }
}