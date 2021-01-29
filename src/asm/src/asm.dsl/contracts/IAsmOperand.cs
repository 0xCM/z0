//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public interface IAsmOperand : ISizedOperand
    {

    }

    public interface IAsmOperand<K,T> : IAsmOperand, ISizedOperand<T>, IKindedOperand<K>
        where K : unmanaged
        where T : unmanaged
    {

    }

    public interface IAsmOperand<T> : IAsmOperand<AsmOperandClass,T>, ISizedOperand<T>
        where T : unmanaged
    {

    }

    public interface IAsmOperand<F,W,T> : IAsmOperand<T>
        where F : unmanaged, IAsmOperand<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        W Width => default(W);
    }
}