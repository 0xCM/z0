//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsmImmOp : IAsmOperand
    {
        AsmOperandKind IAsmOperand.OpKind
            => AsmOperandKind.Imm;
    }

    public interface IAsmImmOp<T> : IAsmImmOp, IAsmOperand<T>
        where T : unmanaged
    {

    }

    public interface IAsmImmOp<W,T> : IAsmImmOp<T>, IAsmOperand<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IAsmImmOp<F,W,T> : IAsmImmOp<W,T>, IAsmOperand<F,W,T>
        where F : unmanaged, IAsmImmOp<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}