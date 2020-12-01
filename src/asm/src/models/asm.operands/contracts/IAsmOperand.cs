//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IAsmOperand : ISizedOperand, IKindedOperand<AsmOperandKind>
    {

    }


    public interface IAsmOperand<T> : IAsmOperand, ISizedOperand<T>
    {

    }

    public interface IAsmOperand<W,T> : IAsmOperand<T>
        where W : unmanaged, IDataWidth
    {

    }

    public interface IAsmOperand<F,W,T> : IAsmOperand<W,T>
        where F : unmanaged, IAsmOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        W Width => default(W);
    }
}