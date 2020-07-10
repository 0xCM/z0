//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static OpacityKind;

    partial struct xsys
    {
        [MethodImpl(Options), Opaque(FillSpan), Closures(Closure)]
        public static void fill<T>(T src, Span<T> dst)
            => dst.Fill(src);

        [MethodImpl(Options), Opaque(InitRefBlock)]
        public static ref byte fill(byte src, ref byte dst, uint length)
        {
            InitBlock(ref dst, src, length);
            return ref dst;
        }            
    }
}