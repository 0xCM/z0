//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmMemOp : IAsmOperand
    {
        AsmOperandKind IAsmOperand.OpKind
            => AsmOperandKind.M;
    }

    public interface IAsmMemOp<T> : IAsmMemOp, IAsmOperand<T>
        where T : unmanaged
    {

    }

    public interface IAsmMemOp<W,T> : IAsmMemOp<T>, IAsmOperand<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IAsmMemOp<F,W,T> : IAsmMemOp<W,T>, IAsmOperand<F,W,T>
        where T : unmanaged
        where F : unmanaged, IAsmMemOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }
}