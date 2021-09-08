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
    using static Blit;

    public readonly struct DfaSymbol<T>
        where T : unmanaged
    {
        public readonly T Value;

        [MethodImpl(Inline)]
        public DfaSymbol(T value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator DfaSymbol<T>(T src)
            => new DfaSymbol<T>(src);
    }

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
            points(interval, dst);
            return recover<DfaState<byte>>(dst);
        }

        [MethodImpl(Inline), Op]
        static void points(Interval<uint> src, Span<byte> dst)
        {
            long i0 = src.Left;
            long i1 = src.Right;
            for(var i=i0; i<i1; i++)
                seek(dst,i) = (byte)i;
        }
    }
}