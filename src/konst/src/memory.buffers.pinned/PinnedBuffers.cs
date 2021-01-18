//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost(ApiNames.PinnedBuffers, true)]
    public readonly struct PinnedBuffers
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static H fetch<H,T>()
            where H : PinnedBuffer<H,T>, new()
                => PinnedBuffer<H,T>.fetch();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PinnedBuffer256<T> fetch<T>(N256 n)
            => PinnedBuffer256<T>.fetch();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> covered<T>(in PinnedBuffer<T> src)
            => first(cover<IndexedSeq<T>>(src.BufferAddress, 1)).Storage;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref PinnedBuffer<T> deposit<T>(T[] src, ref PinnedBuffer<T> dst)
        {
            dst.Deposit(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T cell<T>(in PinnedBuffer<T> src, uint index, out T value)
        {
            value = seek(src.Content, index);
            return ref value;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(in PinnedBuffer<T> src, uint offset)
            => z.slice(covered(src), offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> slice<T>(in PinnedBuffer<T> src, uint offset, uint length)
            => z.slice(covered(src), offset, length);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void enumerate<T>(in PinnedBuffer<T> src, Action<T> receiver)
        {
            var buffer = covered(src);
            var count = src.CellCount;
            for(var i=0; i<count; i++)
                receiver(skip(buffer, i));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void enumerate<T>(in PinnedBuffer<T> src, in ClosedInterval<uint> range, Action<T> receiver)
        {
            var buffer = covered(src);
            var i0 = range.Min;
            var i1 = range.Max;
            for(var i= i0; i<=i1; i++)
                receiver(skip(buffer, i));
        }
    }
}