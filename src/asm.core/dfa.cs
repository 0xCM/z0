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

    using bv = Blit.bv;

    public readonly struct DfaState<T>
        where T : unmanaged
    {
        readonly T B {get;}

        [MethodImpl(Inline)]
        public DfaState(T b)
        {
            B = b;
        }

        public T Content
        {
            [MethodImpl(Inline)]
            get => B;
        }

        [MethodImpl(Inline)]
        public static implicit operator DfaState<T>(T src)
            => new DfaState<T>(src);
    }

    [ApiHost]
    public readonly partial struct Dfa
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DfaState<T> state<T>(T src)
            where T : unmanaged
                => new DfaState<T>(src);

        [Op]
        public static ReadOnlySpan<DfaState<byte>> states(uint width, W8 w)
        {
            var count = Pow2.pow((byte)width);
            var dst = span<byte>(count);
            var interval = Intervals.closed<uint>(0, (uint)count);
            discretize(interval, dst);
            return recover<DfaState<byte>>(dst);
        }

        [Op]
        public static bv bitvector(uint width, byte src, Span<bit> buffer)
        {
            var input = src;
            var storage = 0ul;
            ref var _dst = ref @as<ulong,bit>(storage);
            Span<bit> dst = alloc<bit>(width);
            for(byte i=0; i<width; i++)
                seek(buffer,i) = bit.test(input,i);
            return new bv(slice(buffer,0,width));
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