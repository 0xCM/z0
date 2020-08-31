
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Memories;
    using static SBlock;

    partial class BSvcHosts
    {
        [Closures(Integers), Xors]
        public readonly struct Xors128<T> : IBlockedUnaryImm8Op128<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock128<T> Invoke(in SpanBlock128<T> a, [Imm] byte count, in SpanBlock128<T> dst)
            {
                var blocks = dst.BlockCount;
                for(var block = 0; block < blocks; block++)
                    Vectors.vstore(gvec.vxors(a.LoadVector(block), count), ref dst.BlockRef(block));
                return ref dst;
            }
        }

        [Closures(Integers), Xors]
        public readonly struct Xors256<T> : IBlockedUnaryImm8Op256<T>
            where T : unmanaged
        {
            [MethodImpl(Inline)]
            public ref readonly SpanBlock256<T> Invoke(in SpanBlock256<T> a, [Imm] byte count, in SpanBlock256<T> dst)
            {
                var blocks = dst.BlockCount;
                for(var block = 0; block < blocks; block++)
                    Vectors.vstore(gvec.vxors(a.LoadVector(block), count), ref dst.BlockRef(block));
                return ref dst;
            }
        }
    }
}