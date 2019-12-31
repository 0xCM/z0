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
        /// <summary>
        /// Stack allocates 64 bits of storage over 1 64-bit segment
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static Stack64 alloc(N64 w, N64 seg = default)
            => default;

        /// <summary>
        /// Stack allocates 64 bits of storage over 8 8-bit segments
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static Stack64 alloc(N64 w, N8 seg)
            => default;

        /// <summary>
        /// Stack allocates 128 bits of storage over 2 64-bit segments
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static Stack128 alloc(N128 w, N64 seg = default)
            => default;

        /// <summary>
        /// Stack allocates 128 bits of storage over 8 16-bit segments
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static Stack128x16 alloc(N128 w, N16 seg)
            => default;

        /// <summary>
        /// Stack allocates 256-bits of storage over 4 64-bit segments
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static Stack256 alloc(N256 w, N64 seg = default)
            => default;

        /// <summary>
        /// Stack allocates 512-bits of storage over 8 64-bit segments
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static Stack512 alloc(N512 w, N64 seg = default)
            => default;

        /// <summary>
        /// Stack allocates 1024-bits of storage over 16 64-bit segments
        /// </summary>
        /// <param name="w">The storage width</param>
        /// <param name="seg">The segment width</param>
        [MethodImpl(Inline)]
        public static Stack1024 alloc(N1024 n, N64 seg = default)
            => default;

        /// <summary>
        /// Retrieves the leading element from the storage source
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head(ref Stack64 src)
            => ref src.X0;

        /// <summary>
        /// Retrieves the leading element from the storage source
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref byte head(ref Stack64x8 src)
            => ref src.X0;

        /// <summary>
        /// Retrieves the leading element from the storage source
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head(ref Stack128 src)
            => ref src.X0;

        /// <summary>
        /// Retrieves the leading element from the storage source
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ushort head(ref Stack128x16 src)
            => ref src.X0;

        /// <summary>
        /// Retrieves the leading element from the storage source
        /// </summary>
        /// <param name="src">The storage source</param>
        [MethodImpl(Inline)]
        public static ref ulong head(ref Stack256 src)
            => ref src.X0.X0;

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack64 src)
            => new Span<ulong>(ptr(ref src.X0), 1).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack128 src)
            => new Span<ulong>(ptr(ref src.X0), 2).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack256 src)
            => new Span<ulong>(ptr(ref head(ref src)), 4).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack512 src)
            => new Span<ulong>(ptr(ref src.X0), 8).AsBytes();

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(ref Stack1024 src)
            => new Span<ulong>(ptr(ref src.X0), 16).AsBytes();

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Stack64 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Stack128 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref src.X0);

        [MethodImpl(Inline)]
        public static ref T head<T>(ref Stack256 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head(ref src.X0));

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
        public static void store(in byte src, uint count, ref Stack128 dst)
        {
            ref var dstBytes = ref uint8(ref dst.X0);
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref mutable(in src), count);
        }

        [MethodImpl(Inline)]
        public static CharStack2 chars(N2 n)
            => default;

        [MethodImpl(Inline)]
        public static CharStack4 chars(N4 n)
            => default;

        [MethodImpl(Inline)]
        public static CharStack8 chars(N8 n)
            => default;

        [MethodImpl(Inline)]
        public static CharStack16 chars(N16 n)
            => default;

        [MethodImpl(Inline)]
        public static unsafe Span<char> charspan(ref CharStack2 src)
            => new Span<char>(ptr(ref src.C0), 2).AsChar();

        [MethodImpl(Inline)]
        public static unsafe Span<char> charspan(ref CharStack4 src)
            => new Span<char>(ptr(ref src.C0), 4).AsChar();

        [MethodImpl(Inline)]
        public static unsafe Span<char> charspan(ref CharStack8 src)
            => new Span<char>(ptr(ref src.C0), 8).AsChar();            

        [MethodImpl(Inline)]
        public static unsafe Span<char> charspan(ref CharStack16 src)
            => new Span<char>(ptr(ref src.C0), 16).AsChar();

        [MethodImpl(Inline)]
        public static unsafe CharStack4 concat(in CharStack2 head, in CharStack2 tail)
        {
            var dst = chars(n4);
            PolyData.copy(in head.C0, ref dst.C0, 2);
            PolyData.copy(in tail.C0, ref seek(ref dst.C0,2), 2);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack8 concat(in CharStack4 head, in CharStack4 tail)
        {
            var dst = chars(n8);
            PolyData.copy(in head.C0, ref dst.C0, 4);
            PolyData.copy(in tail.C0, ref seek(ref dst.C0,4), 4);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static CharStack16 concat(in CharStack8 head, in CharStack8 tail)
        {
            var dst = chars(n16);
            PolyData.copy(in head.C0, ref dst.C0, 8);
            PolyData.copy(in tail.C0, ref seek(ref dst.C0,8), 8);            
            return dst;
        }
    }
}