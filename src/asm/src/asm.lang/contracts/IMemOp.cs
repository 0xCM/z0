//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IMemOp : IAsmOperand
    {

    }

    [Free]
    public interface IMemOp<T> : IMemOp, IAsmOperand<T>
        where T : unmanaged
    {
        AsmOperandClass IKinded<AsmOperandClass>.Kind
            => AsmOperandClass.M;
    }

    [Free]
    public interface IMemOp<F,W,T> : IMemOp<T>
        where T : unmanaged
        where F : unmanaged, IMemOp<F,W,T>
        where W : unmanaged, ITypeWidth
    {
        W Width => default(W);
    }
}