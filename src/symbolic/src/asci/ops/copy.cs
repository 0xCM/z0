//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Seed;
    using static Typed;
    using static Control;

    partial class AsciCodes
    {
        [MethodImpl(Inline), Op]
        public static unsafe void copy(in AsciCode16 src, ref byte dst)
            => Store(ptr(ref dst), src.Storage);            

        [MethodImpl(Inline), Op]
        public static unsafe void copy(in AsciCode16 src, Span<byte> dst)
            => copy(src, ref head(dst));
    }
}