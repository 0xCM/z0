//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Root;
    using static core;
    using static Dfa;

    using api = dfa;

    public readonly partial struct Dfa
    {
        public readonly ref struct BitVector
        {
            readonly Span<bit> Bits;

            [MethodImpl(Inline)]
            public BitVector(Span<bit> b)
            {
                Bits = b;
            }

            public uint Width
            {
                [MethodImpl(Inline)]
                get => (uint)Bits.Length;
            }

            public ref bit this[long i]
            {
                [MethodImpl(Inline)]
                get => ref seek(Bits,i);
            }

            public ref bit this[ulong i]
            {
                [MethodImpl(Inline)]
                get => ref seek(Bits,i);
            }

            public string Format()
                => api.format(this);
        }

        public struct BitVector<T>
            where T : unmanaged
        {
            public uint Width;

            public T Bits;

            [MethodImpl(Inline)]
            public BitVector(uint d, T bits)
            {
                Width = d;
                Bits = bits;
            }
        }

        public readonly struct State<T>
            where T : unmanaged
        {
            readonly T B {get;}

            [MethodImpl(Inline)]
            public State(T b)
            {
                B = b;
            }

            public T Content
            {
                [MethodImpl(Inline)]
                get => B;
            }

            [MethodImpl(Inline)]
            public static implicit operator State<T>(T src)
                => new State<T>(src);
        }
    }

    [ApiHost]
    public readonly partial struct dfa
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static State<T> state<T>(T src)
            where T : unmanaged
                => new State<T>(src);

        [MethodImpl(Inline), Op]
        public static State<byte> state(byte src)
            => src;

        [MethodImpl(Inline), Op]
        public static State<ushort> state(ushort src)
            => src;

        [MethodImpl(Inline), Op]
        public static State<uint> state(uint src)
            => src;

        [MethodImpl(Inline), Op]
        public static State<ulong> state(ulong src)
            => src;

        [MethodImpl(Inline), Op]
        public static State<Cell128> state(Cell128 src)
            => src;

        [MethodImpl(Inline), Op]
        public static State<Cell256> state(Cell256 src)
            => src;

        [MethodImpl(Inline), Op]
        public static State<Cell512> state(Cell512 src)
            => src;

        [Op]
        public static ReadOnlySpan<State<byte>> states(uint width, W8 w)
        {
            var count = Pow2.pow((byte)width);
            var dst = span<byte>(count);
            var interval = Intervals.closed<uint>(0, (uint)count);
            discretize(interval, dst);
            return recover<State<byte>>(dst);
        }

        [Op]
        public static string format(in BitVector src)
        {
            var count = (int)src.Width;
            Span<char> buffer = stackalloc char[count];
            for(var i=0; i<count; i++)
                seek(buffer,i) = src[i].ToChar();
            buffer.Reverse();
            return text.format(buffer);
        }

        [Op]
        public static BitVector bitvector(uint width, State<byte> src)
        {
            var input = src.Content;
            var storage = 0ul;
            ref var _dst = ref @as<ulong,bit>(storage);
            Span<bit> dst = alloc<bit>(width);
            for(byte i=0; i<width; i++)
                seek(dst,i) = bit.test(input,i);
            return new BitVector(dst);
        }

        [Op]
        public static BitVector bitvector(uint width, State<byte> src, Span<bit> buffer)
        {
            var input = src.Content;
            var storage = 0ul;
            ref var _dst = ref @as<ulong,bit>(storage);
            Span<bit> dst = alloc<bit>(width);
            for(byte i=0; i<width; i++)
                seek(buffer,i) = bit.test(input,i);
            return new BitVector(slice(buffer,0,width));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitVector<T> bitvector<T>(uint width, T src)
            where T : unmanaged
                => new BitVector<T>(width, src);

        [MethodImpl(Inline), Op]
        public static BitVector<ushort> bitvector(uint width, State<ushort> src)
            => bitvector(width, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<uint> bitvector(uint width, State<uint> src)
            => bitvector(width, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<ulong> bitvector(uint width, State<ulong> src)
            => bitvector(width, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<Cell128> bitvector(uint width, State<Cell128> src)
            => bitvector(width, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<Cell256> bitvector(uint width, State<Cell256> src)
            => bitvector(width, src.Content);

        [Op]
        public static BitVector<Cell512> bitvector(uint width, State<Cell512> src)
            => bitvector(width, src.Content);

        [MethodImpl(Inline), Op]
        static void discretize(Interval<uint> src, Span<byte> dst)
        {
            long i0 = src.Left;
            long i1 = src.Right;
            for(var i=i0; i<i1; i++)
                seek(dst,i) = (byte)i;
        }
    }
}