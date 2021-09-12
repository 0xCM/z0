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
        [MethodImpl(Inline), Op]
        public static StringHash strings()
            => default(StringHash);

        public static uint collisions<S,T>(Index<S> src, IHashFunction<S,T> hash)
            where T : unmanaged
        {
            var accumulator = hashset<T>();
            var count = src.Count;
            var view = src.View;
            for(var i=0; i<count; i++)
                accumulator.Add(hash.Compute(skip(view, i)));
            return count - (uint)accumulator.Count;
        }

        public static Outcome perfect(ReadOnlySpan<MemorySymbol> src, out Index<HashEntry> dst)
        {
            var result = Outcome.Success;
            dst = default;
            var codes = src.Map(x => x.HashCode);
            var count = (uint)codes.Length;
            dst = alloc<HashEntry>(count);
            ref var records = ref dst.First;
            for(var i=0; i<count; i++)
            {
                ref var record = ref seek(records,i);
                ref readonly var hash = ref skip(codes,i);
                record.Code = hash;
                record.Key = (hash % count);
                record.Content = skip(src,i).Expr.Text;
            }

            var distinct = hashset(dst.Storage);
            if(distinct.Count != count)
                result = (false, "Imperfect");

            return result;
        }

        public static Outcome perfect(ReadOnlySpan<string> src, out Index<HashEntry> dst)
        {
            var result = Outcome.Success;

            dst = default;
            try
            {
                var codes = perfect(src, x => x, HashFunctions.strings()).Codes;
                var count = (uint)codes.Length;
                dst = alloc<HashEntry>(count);
                ref var records = ref dst.First;
                for(var i=0; i<count; i++)
                {
                    ref var record = ref seek(records,i);
                    ref readonly var hash = ref skip(codes,i);
                    record.Code = hash.Hash;
                    record.Key = (hash.Hash % count);
                    record.Content = hash.Source;
                }
                dst.Sort();
            }
            catch(Exception e)
            {
                result = e;
            }

            return result;
        }

        public static HashedIndex<T> perfect<T>(ReadOnlySpan<T> src, Func<T,string> f, StringHash hasher)
        {
            var count = src.Length;
            var buffer = alloc<HashCode<T>>(count);
            ref var dst = ref first(buffer);
            var accumulator = hashset<uint>();
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                var computed = hasher.Compute(f(input));
                seek(dst,i) = (input, computed);
                accumulator.Add(computed);
            }
            var collisions = count - (uint)accumulator.Count;
            if(collisions != 0)
                @throw("Imperfect");
            return new HashedIndex<T>(buffer, t => hasher.Compute(f(t)));
        }

        public static HashedIndex<T> perfect<T>(ReadOnlySpan<T> src, Func<T,string> format)
        {
            var count = src.Length;
            var buffer = alloc<HashCode<T>>(count);
            ref var dst = ref first(buffer);
            var accumulator = hashset<uint>();
            var algorithm = strings();
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(src,i);
                var computed = algorithm.Compute(format(input));
                seek(dst,i) = (input, computed);
                accumulator.Add(computed);
            }
            var collisions = count - (uint)accumulator.Count;
            if(collisions != 0)
                @throw("Imperfect");
            return new HashedIndex<T>(buffer, t => algorithm.Compute(format(t)));
        }
    }
}