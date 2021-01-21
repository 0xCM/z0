//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref T first<T>(Span<T> src)
            => ref memory.first(src);

        [MethodImpl(Inline)]
        public static ref readonly char first(ReadOnlySpan<char> src)
            => ref memory.first(src);

        [MethodImpl(Inline)]
        public static ref readonly T first<T>(ReadOnlySpan<T> src)
            => ref memory.first(src);

        [MethodImpl(Inline)]
        public static ref T first<T>(T[] src)
            => ref memory.first(src);

        [MethodImpl(Inline)]
        public static ref readonly byte first<T>(W8 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref As<T,byte>(ref GetReference(src));

        [MethodImpl(Inline)]
        public static ref readonly ushort first<T>(W16 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref memory.first(w, src);

        [MethodImpl(Inline)]
        public static ref readonly uint first<T>(W32 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref memory.first(w, src);

        [MethodImpl(Inline)]
        public static ref readonly ulong first<T>(W64 w, ReadOnlySpan<T> src)
            where T : unmanaged
                => ref memory.first(w, src);

        [MethodImpl(Inline)]
        public static ref byte first<T>(W8 w, Span<T> src)
            where T : unmanaged
                => ref memory.first(w, src);

        [MethodImpl(Inline)]
        public static ref ushort first<T>(W16 w, Span<T> src)
            where T : unmanaged
                => ref memory.first(w, src);

        [MethodImpl(Inline)]
        public static ref uint first<T>(W32 w, Span<T> src)
            where T : unmanaged
                => ref memory.first(w, src);

        [MethodImpl(Inline)]
        public static ref ulong first<T>(W64 w, Span<T> src)
            where T : unmanaged
                => ref memory.first(w, src);
    }
}