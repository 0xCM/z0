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
        public readonly struct Domain
        {
            public uint Width {get;}

            [MethodImpl(Inline)]
            public Domain(uint width)
            {
                Width = width;
            }

            public string Format()
                => string.Format("w{0}",Width);

            public override string ToString()
                => Format();
        }

        public readonly struct Symbol
        {
            public ushort Key {get;}

            [MethodImpl(Inline)]
            public Symbol(ushort index)
            {
                Key = index;
            }

            public string Format()
                => Key.ToString();

            public override string ToString()
                => Format();
        }


        public struct SymbolStore<T>
        {
            readonly Index<T> Data;

            uint k;

            internal SymbolStore(ushort capacity)
            {
                Data = alloc<T>(capacity);
                k = 0;
            }

            [MethodImpl(Inline)]
            public T Extract(in Symbol src)
            {
                return Data[src.Key];
            }

            [MethodImpl(Inline)]
            public bit Deposit(in T src, out Symbol dst)
            {
                if(k < Data.Length - 1)
                {
                    Data[k] = src;
                    dst = new Symbol((ushort)k);
                    k++;
                    return true;
                }
                else
                {
                    dst = default;
                    return false;
                }
            }
        }

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
            Domain Domain;

            T Bits;

            [MethodImpl(Inline)]
            public BitVector(Domain d, T bits)
            {
                Domain = d;
                Bits = bits;
            }

            public uint Width
            {
                [MethodImpl(Inline)]
                get => Domain.Width;
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

        public static SymbolStore<T> symstore<T>(ushort capacity)
            => new SymbolStore<T>(capacity);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static bit deposit<T>(in T src, ref SymbolStore<T> dst, out Symbol s)
            => dst.Deposit(src, out s);

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
        public static ReadOnlySpan<State<byte>> states(Domain d, W8 w)
        {
            var count = Pow2.pow((byte)d.Width);
            var dst = span<byte>(count);
            var interval = Intervals.closed<uint>(0, (uint)count);
            discretize(interval, dst);
            return recover<State<byte>>(dst);
        }

        [MethodImpl(Inline), Op]
        public static Domain dmax<T>()
            where T : unmanaged
                => domain(width<T>());

        [MethodImpl(Inline), Op]
        public static Domain domain(uint width)
            => new Domain(width);

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
        public static BitVector bitvector(Domain d, State<byte> src)
        {
            var width = (int)d.Width;
            var input = src.Content;
            var storage = 0ul;
            ref var _dst = ref @as<ulong,bit>(storage);
            Span<bit> dst = alloc<bit>(width);
            for(byte i=0; i<width; i++)
                seek(dst,i) = bit.test(input,i);
            return new BitVector(dst);
        }

        [Op]
        public static BitVector bitvector(Domain d, State<byte> src, Span<bit> buffer)
        {
            var width = (int)d.Width;
            var input = src.Content;
            var storage = 0ul;
            ref var _dst = ref @as<ulong,bit>(storage);
            Span<bit> dst = alloc<bit>(width);
            for(byte i=0; i<width; i++)
                seek(buffer,i) = bit.test(input,i);
            return new BitVector(slice(buffer,0,width));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BitVector<T> bitvector<T>(Domain d, T src)
            where T : unmanaged
                => new BitVector<T>(d, src);

        [MethodImpl(Inline), Op]
        public static BitVector<ushort> bitvector(Domain d, State<ushort> src)
            => bitvector(d, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<uint> bitvector(Domain d, State<uint> src)
            => bitvector(d, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<ulong> bitvector(Domain d, State<ulong> src)
            => bitvector(d, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<Cell128> bitvector(Domain d, State<Cell128> src)
            => bitvector(d, src.Content);

        [MethodImpl(Inline), Op]
        public static BitVector<Cell256> bitvector(Domain d, State<Cell256> src)
            => bitvector(d, src.Content);

        [Op]
        public static BitVector<Cell512> bitvector(Domain d, State<Cell512> src)
            => bitvector(d, src.Content);

        [Op, Closures(Closure)]
        public static BitVector bitvector<T>(Domain d, State<T> src)
            where T : unmanaged
        {
            var input = bytes(src.Content);
            var dst = default(Span<bit>);
            switch(d.Width)
            {
                case 1:
                    {
                        var storage = ByteBlock1.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first(input), d, dst);
                    }
                    break;
                case 2:
                    {
                        var storage = ByteBlock2.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first(input), d, dst);
                    }
                    break;
                case 3:
                    {
                        var storage = ByteBlock3.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first(input), d, dst);
                    }
                    break;
                case 4:
                    {
                        var storage = ByteBlock4.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first(input), d, dst);
                    }
                    break;
                case 5:
                    {
                        var storage = ByteBlock5.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first(input), d, dst);
                    }
                    break;
                case 6:
                    {
                        var storage = ByteBlock6.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first(input), d, dst);
                    }
                    break;
                case 7:
                    {
                        var storage = ByteBlock7.Empty;
                        dst = recover<bit>(storage.Bytes);
                         unpack(first(input), d, dst);
                    }
                    break;
                case 8:
                    {
                        var storage = ByteBlock8.Empty;
                        dst = recover<bit>(storage.Bytes);
                         unpack(first(input), d, dst);
                    }
                    break;
                case 9:
                    {
                        var storage = ByteBlock9.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 10:
                    {
                        var storage = ByteBlock10.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 11:
                    {
                        var storage = ByteBlock11.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 12:
                    {
                        var storage = ByteBlock12.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 13:
                    {
                        var storage = ByteBlock13.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 14:
                    {
                        var storage = ByteBlock14.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 15:
                    {
                        var storage = ByteBlock15.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 16:
                    {
                        var storage = ByteBlock16.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first16u(input), d, dst);
                    }
                    break;
                case 17:
                    {
                        var storage = ByteBlock17.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 18:
                    {
                        var storage = ByteBlock18.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 19:
                    {
                        var storage = ByteBlock19.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 20:
                    {
                        var storage = ByteBlock20.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 21:
                    {
                        var storage = ByteBlock21.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 22:
                    {
                        var storage = ByteBlock22.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 23:
                    {
                        var storage = ByteBlock23.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 24:
                    {
                        var storage = ByteBlock24.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 25:
                    {
                        var storage = ByteBlock25.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 26:
                    {
                        var storage = ByteBlock26.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 27:
                    {
                        var storage = ByteBlock27.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 28:
                    {
                        var storage = ByteBlock28.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 29:
                    {
                        var storage = ByteBlock29.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 30:
                    {
                        var storage = ByteBlock30.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 31:
                    {
                        var storage = ByteBlock31.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;
                case 32:
                    {
                        var storage = ByteBlock32.Empty;
                        dst = recover<bit>(storage.Bytes);
                        unpack(first32u(input), d, dst);
                    }
                    break;

            }

            return new BitVector(dst);
        }

        [MethodImpl(Inline)]
        static void unpack(byte src, Domain d, Span<bit> dst)
        {
            for(byte i=0; i<d.Width; i++)
                seek(dst,i) = bit.test(src,i);
        }

        [MethodImpl(Inline)]
        static void unpack(ushort src, Domain d, Span<bit> dst)
        {
            for(byte i=0; i<d.Width; i++)
                seek(dst,i) = bit.test(src,i);
        }

        [MethodImpl(Inline)]
        static void unpack(uint src, Domain d, Span<bit> dst)
        {
            var k=0u;
            for(byte i=0; i<d.Width; i++)
                seek(dst,i) = bit.test(src,i);
        }

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