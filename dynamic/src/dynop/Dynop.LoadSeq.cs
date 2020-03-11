//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Dynop
    {
        public static FixedUnaryOp<F> LoadUnaryOp<F>(this in BufferSeq<F> buffers, int index, AsmCode src)
            where F : unmanaged, IFixed
                => buffers[index].LoadFixedUnaryOp<F>(src);

        public static FixedBinaryOp<F> LoadBinaryOp<F>(this in BufferSeq<F> buffers, int index, AsmCode src)
            where F : unmanaged, IFixed
                => buffers[index].LoadFixedBinaryOp<F>(src);

        public static FixedTernaryOp<F> LoadTernaryOp<F>(this in BufferSeq<F> buffers, int index, AsmCode src)
            where F : unmanaged, IFixed
                => buffers[index].LoadFixedTernaryOp<F>(src);
    }
}