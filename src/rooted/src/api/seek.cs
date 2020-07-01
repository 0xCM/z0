//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Roots
    {
        [MethodImpl(Inline)]
        public static ref T seek<T>(ref T src, byte count)
            => ref As.seek(src, count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(ref T src, int count)
            => ref As.seek(src, count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, byte count)
            => ref As.seek(src, count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, ushort count)
            => ref As.seek(src, count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, int count)
            => ref As.seek(src, (uint)count);

        [MethodImpl(Inline)]
        public static ref T seek<T>(Span<T> src, uint count)
            => ref As.seek(src, count); 
    }
}