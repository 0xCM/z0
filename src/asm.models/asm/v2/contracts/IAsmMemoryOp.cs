//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsmMemoryOp : IAsmOperand
    {
        AsmOperandKind IAsmOperand.OpKind
            => AsmOperandKind.M;
    }

    public interface IAsmMemoryOp<T> : IAsmMemoryOp, IAsmOperand<T>
        where T : unmanaged
    {

    }

    public interface IAsmMemoryOp<W,T> : IAsmMemoryOp<T>, IAsmOperand<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IAsmMemoryOp<F,W,T> : IAsmMemoryOp<W,T>, IAsmOperand<F,W,T>
        where T : unmanaged
        where F : unmanaged, IAsmMemoryOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }
}