//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    using static BlockStorage;

    public static class DataBlocks
    {
        [MethodImpl(Inline)]
        public static Block128 alloc(N128 n)
            => default;

        [MethodImpl(Inline)]
        public static Block256 alloc(N256 n)
            => default;

        [MethodImpl(Inline)]
        public static Block512 alloc(N512 n)
            => default;

        [MethodImpl(Inline)]
        public static Block1024 alloc(N1024 n)
            => default;

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block128 src)
            => new Span<ulong>(refptr(ref src.X0), 2).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block256 src)
            => new Span<ulong>(refptr(ref src.X0), 4).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block512 src)
            => new Span<ulong>(refptr(ref src.X0), 8).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Block1024 src)
            => new Span<ulong>(refptr(ref src.X0), 16).AsBytes();

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Block128 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Block256 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Block512 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Block1024 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T value<T>(ref Block128 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);
            
        [MethodImpl(Inline)]
        public static ref T value<T>(ref Block256 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        [MethodImpl(Inline)]
        public static ref T value<T>(ref Block512 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        [MethodImpl(Inline)]
        public static ref T value<T>(ref Block1024 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        [MethodImpl(Inline)]
        public static Block256 concat(in Block128 head, in Block128 tail)
        {
            Block256 dst = default;
            value<ulong>(ref dst, 3) = head.X1;
            value<ulong>(ref dst, 2) = head.X0;
            value<ulong>(ref dst, 1) = tail.X1;
            value<ulong>(ref dst, 0) = tail.X0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static Block512 concat(in Block256 head, in Block256 tail)
        {
            Block512 dst = default;
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
        public static void store(in byte src, uint count, ref Block128 dst)
        {
            ref var dstBytes = ref uint8(ref dst.X0);
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref mutable(in src), count);
        }

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharBlock2 src)
            => new Span<char>(ptr(ref src.C0), 2).AsChar();

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharBlock4 src)
            => new Span<char>(ptr(ref src.C0), 4).AsChar();

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharBlock8 src)
            => new Span<char>(ptr(ref src.C0), 8).AsChar();            

        [MethodImpl(Inline)]
        public static unsafe Span<char> chars(ref CharBlock16 src)
            => new Span<char>(ptr(ref src.C0), 8).AsChar();

        [MethodImpl(Inline)]
        public static CharBlock4 concat(in CharBlock2 head, in CharBlock2 tail)
        {
            CharBlock4 dst = default;
            dst.C3 = head.C1;
            dst.C2 = head.C0;
            dst.C1 = tail.C1;
            dst.C0 = tail.C0;
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharBlock8 concat(in CharBlock4 head, in CharBlock4 tail)
        {
            CharBlock8 dst = default;
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
        public static CharBlock16 concat(in CharBlock8 head, in CharBlock8 tail)
        {
            CharBlock16 dst = default;
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