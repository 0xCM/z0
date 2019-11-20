//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    using static StackContainers;

    public static class StackStore
    {
        [MethodImpl(Inline)]
        public static Stack128 alloc(N128 n)
            => default;

        [MethodImpl(Inline)]
        public static Stack256 alloc(N256 n)
            => default;

        [MethodImpl(Inline)]
        public static Stack512 alloc(N512 n)
            => default;

        [MethodImpl(Inline)]
        public static Stack1024 alloc(N1024 n)
            => default;

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack128 src)
            => new Span<ulong>(refptr(ref src.X0), 2).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack256 src)
            => new Span<ulong>(refptr(ref src.X0), 4).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack512 src)
            => new Span<ulong>(refptr(ref src.X0), 8).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack1024 src)
            => new Span<ulong>(refptr(ref src.X0), 16).AsBytes();

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Stack128 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Stack256 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Stack512 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Stack1024 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T value<T>(ref Stack128 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);
            
        [MethodImpl(Inline)]
        public static ref T value<T>(ref Stack256 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        [MethodImpl(Inline)]
        public static ref T value<T>(ref Stack512 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        [MethodImpl(Inline)]
        public static ref T value<T>(ref Stack1024 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        [MethodImpl(Inline)]
        public static Stack256 concat(in Stack128 head, in Stack128 tail)
        {
            Stack256 dst = default;
            value<ulong>(ref dst, 3) = head.X1;
            value<ulong>(ref dst, 2) = head.X0;
            value<ulong>(ref dst, 1) = tail.X1;
            value<ulong>(ref dst, 0) = tail.X0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static Stack512 concat(in Stack256 head, in Stack256 tail)
        {
            Stack512 dst = default;
            value<ulong>(ref dst, 7) = head.X3;
            value<ulong>(ref dst, 6) = head.X2;
            value<ulong>(ref dst, 5) = head.X1;
            value<ulong>(ref dst, 4) = head.X0;
            value<ulong>(ref dst, 3) = tail.X3;
            value<ulong>(ref dst, 2) = tail.X2;
            dst.X1 = tail.X1;
            dst.X0 = tail.X0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static void store(in byte src, uint count, ref Stack128 dst)
        {
            ref var dstBytes = ref uint8(ref dst.X0);
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref mutable(in src), count);
        }

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharStack2 src)
            => new Span<char>(ptr(ref src.C0), 2).AsChar();

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharStack4 src)
            => new Span<char>(ptr(ref src.C0), 4).AsChar();

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharStack8 src)
            => new Span<char>(ptr(ref src.C0), 8).AsChar();            

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharStack16 src)
            => new Span<char>(ptr(ref src.C0), 8).AsChar();

        [MethodImpl(Inline)]
        public static CharStack4 concat(in CharStack2 head, in CharStack2 tail)
        {
            CharStack4 dst = default;
            dst.C3 = head.C1;
            dst.C2 = head.C0;
            dst.C1 = tail.C1;
            dst.C0 = tail.C0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack8 concat(in CharStack4 head, in CharStack4 tail)
        {
            CharStack8 dst = default;
            dst.C7 = head.C3;
            dst.C6 = head.C2;
            dst.C5 = head.C1;
            dst.C4 = head.C0;
            dst.C3 = tail.C3;
            dst.C2 = tail.C2;
            dst.C1 = tail.C1;
            dst.C0 = tail.C0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack16 concat(in CharStack8 head, in CharStack8 tail)
        {
            CharStack16 dst = default;
            dst.CF = head.C7;
            dst.CE = head.C6;
            dst.CD = head.C5;
            dst.CC = head.C4;
            dst.CB = head.C3;
            dst.CA = head.C2;
            dst.C9 = head.C1;
            dst.C8 = head.C0;
            dst.C7 = tail.C7;
            dst.C6 = tail.C6;
            dst.C5 = tail.C5;
            dst.C4 = tail.C4;
            dst.C3 = tail.C3;
            dst.C2 = tail.C2;
            dst.C1 = tail.C1;
            dst.C0 = tail.C0;
            return dst;
        }
    }
}