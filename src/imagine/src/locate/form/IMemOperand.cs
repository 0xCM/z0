//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IMemOperand : IOperand
    {
        AsmOperandKind IOperand.OpKind 
            => AsmOperandKind.M;
    }

    public interface IMemOperand<T> : IMemOperand, IOperand<T>
        where T : unmanaged
    {

    }

    public interface IMemOperand<W,T> : IMemOperand<T>, IOperand<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        
    }

    public interface IMemOperand<F,W,T> : IMemOperand<W,T>, IOperand<F,W,T>
        where T : unmanaged
        where F : unmanaged, IMemOperand<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }
}