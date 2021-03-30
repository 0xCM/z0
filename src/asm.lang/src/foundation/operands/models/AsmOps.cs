//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct AsmOps
    {
        Cell128 Data;

        [MethodImpl(Inline)]
        public AsmOps(Cell128 src)
            => Data = src;

        public AsmOps(IAsmOp a, IAsmOp b, IAsmOp c, IAsmOp d)
            => Data = default;

        public AsmOps(IAsmOp a, IAsmOp b, IAsmOp c)
            => Data = default;

        public AsmOps(IAsmOp a)
            => Data = default;

        public AsmOps(IAsmOp a, IAsmOp b)
            => Data = default;

        public ref uint this[uint2 index]
        {
            [MethodImpl(Inline)]
            get => ref memory.seek32(Data.Bytes,index);
        }

        public static AsmOps Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}