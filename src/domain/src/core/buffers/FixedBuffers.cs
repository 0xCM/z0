//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.FixedBuffers, true)]
    public readonly struct FixedBuffers
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static H fetch<H,T>()
            where H : FixedBuffer<H,T>, new()
                => FixedBuffer<H,T>.fetch();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static FixedBuffer256<T> fetch<T>(N256 n)
            => FixedBuffer256<T>.fetch();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> covered<T>(in FixedBuffer<T> src)
            => first(cover<IndexedSeq<T>>(src.BufferAddress, 1)).Content;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(in FixedBuffer<T> src, uint index, out T value)
        {
            value = seek(src.Data, index);
            return ref value;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(in FixedBuffer<T> src, uint offset)
            => z.slice(covered(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(in FixedBuffer<T> src, uint offset, uint length)
            => z.slice(covered(src), offset, length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void enumerate<T>(in FixedBuffer<T> src, Action<T> receiver)
        {
            var buffer = covered(src);
            var count = src.CellCount;
            for(var i=0; i<count; i++)
                receiver(skip(buffer, i));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void enumerate<T>(in FixedBuffer<T> src, in ClosedInterval<uint> range, Action<T> receiver)
        {
            var buffer = covered(src);
            var i0 = range.Min;
            var i1 = range.Max;
            for(var i= i0; i<=i1; i++)
                receiver(skip(buffer, i));
        }

        public static void apply<I,T>(Loop<I> loop, in FixedBuffer<T> src)
            where I : unmanaged
        {

        }
    }
}