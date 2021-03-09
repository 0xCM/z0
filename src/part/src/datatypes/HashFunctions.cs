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

    public readonly struct HashCode<S,T>
    {
        public S Input {get;}

        public T Output {get;}

        [MethodImpl(Inline)]
        public HashCode(S input, T output)
        {
            Input = input;
            Output = output;
        }
    }

    public readonly struct HashCode<S> : ITextual
    {
        public S Input {get;}

        public uint Output {get;}

        [MethodImpl(Inline)]
        public HashCode(S input, uint output)
        {
            Input = input;
            Output = output;
        }

        public string Format()
            => string.Format("{0}: {1}", Output.FormatHex(specifier:false), Input);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator HashCode<S>((S input, uint output) src)
            => new HashCode<S>(src.input, src.output);
    }

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

        public static Index<HashCode<string>> perfect(Index<string> src)
        {
            var view = src.View;
            var count = view.Length;
            var buffer = alloc<HashCode<string>>(count);
            ref var dst = ref first(buffer);
            var accumulator = root.hashset<uint>();
            var algorithm = strings();
            for(var i=0; i<count; i++)
            {
                ref readonly var input = ref skip(view,i);
                var computed = algorithm.Compute(input);
                seek(dst,i) = (input,computed);
                accumulator.Add(computed);
            }
            var collisions = count - (uint)accumulator.Count;
            if(collisions != 0)
                root.@throw("Imperfect");
            return buffer;
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