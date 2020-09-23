//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAsmImmOperand : IAsmArg
    {
        AsmOperandKind IAsmArg.OpKind
            => AsmOperandKind.Imm;
    }

    public interface IAsmImmArg<T> : IAsmImmOperand, IAsmArg<T>
        where T : unmanaged
    {

    }

    public interface IAsmImmArg<W,T> : IAsmImmArg<T>, IAsmArg<W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }

    public interface IAsmImmArg<F,W,T> : IAsmImmArg<W,T>, IAsmArg<F,W,T>
        where F : unmanaged, IAsmImmArg<F,W,T>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {

    }
}