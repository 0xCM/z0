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

    public struct PerfectHash<T>
    {
        public T Subject {get;}

        public uint Hash {get;}

        public uint Index {get;}

        [MethodImpl(Inline)]
        public PerfectHash(T src, uint hash, uint index)
        {
            Subject = src;
            Hash = hash;
            Index = index;
        }
    }

    public readonly struct HashedIndex<T>
    {
        readonly Index<T> _Data;

        readonly Index<HashCode<T>> _Codes;

        readonly Func<T,uint> HashFunction;

        internal HashedIndex(Index<HashCode<T>> src, Func<T,uint> fx)
        {
            var count = src.Count;
            HashFunction = fx;
            _Data = sys.alloc<T>(count);
            _Codes = src;
            ref var target = ref _Data.First;
            ref readonly var source = ref _Codes.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(source,i);
                var index = code.Hash % count;
                seek(target,index) = code.Source;
            }
        }

        [MethodImpl(Inline)]
        public ref readonly HashCode<T> Code(uint index)
            => ref _Codes[index];

        [MethodImpl(Inline)]
        public ref readonly T Item(uint index)
            => ref _Data[index];

        [MethodImpl(Inline)]
        public uint? Index(in T src)
        {
            var h = HashFunction(src);
            if(h < _Codes.Length)
                return h % _Data.Count;
            else
                return null;
        }

        [MethodImpl(Inline)]
        public bool Contains(in T src)
            => HashFunction(src) < _Codes.Length;

        public ReadOnlySpan<HashCode<T>> Codes
        {
            [MethodImpl(Inline)]
            get => _Codes.View;
        }
    }

    public readonly struct HashCode<S> : ITextual
    {
        public S Source {get;}

        public uint Hash {get;}

        [MethodImpl(Inline)]
        public HashCode(S src, uint hash)
        {
            Source = src;
            Hash = hash;
        }

        public string Format()
            => string.Format("{0}: {1}", Hash.FormatHex(specifier:false), Source);

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