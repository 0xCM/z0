//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

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
    }

    public delegate T HashFunction<T>(ReadOnlySpan<byte> src)
        where T : unmanaged;

    public interface IHashFunction<S,T>
        where T : unmanaged
    {
        T Compute(in S src);
    }

    public interface IHashFunction<T>
        where T : unmanaged
    {
        T Compute<S>(in S src);
    }

    public interface IHashFunction : IHashFunction<uint>
    {

    }

    public readonly struct StringHash : IHashFunction<string,uint>
    {
        [MethodImpl(Inline)]
        public uint Compute(in string src)
            => alg.hash.marvin(bytes(src));
    }
}