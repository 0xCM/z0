//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrix
    {        
        [MethodImpl(Inline)]
        public static BitMatrix4 primal(N4 n, ushort src)
            => BitMatrix4.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 primal(N8 n, Span<byte> src)
            => BitMatrix8.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 primal(N8 n, ReadOnlySpan<byte> src)
            => BitMatrix8.From(src.Replicate());

        [MethodImpl(Inline)]
        public static BitMatrix16 primal(N16 n, Span<ushort> src)
            => BitMatrix16.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 primal(N16 n, ReadOnlySpan<byte> src)
            => BitMatrix16.From(src.Replicate());

        [MethodImpl(Inline)]
        public static BitMatrix32 primal(N32 n, Span<uint> src)
            => BitMatrix32.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 primal(N32 n, ReadOnlySpan<byte> src)
            => BitMatrix32.From(src.Replicate());

        [MethodImpl(Inline)]
        public static BitMatrix64 primal(N64 n, Span<ulong> src)
            => BitMatrix64.From(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 primal(N64 n, ReadOnlySpan<byte> src)
            => BitMatrix64.From(src.Replicate());
    }
}