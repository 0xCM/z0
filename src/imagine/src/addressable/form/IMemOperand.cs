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

    public interface IMemOperand8<F,T> : IMemOperand<F,W8,T>
        where F : unmanaged, IMemOperand8<F,T>
        where T : unmanaged
    {

    }

    public interface IMemOperand16<F,T> : IMemOperand<F,W16,T>
        where F : unmanaged, IMemOperand16<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand32<F,T> : IMemOperand<F,W32,T>
        where F : unmanaged, IMemOperand32<F,T>
        where T : unmanaged
    {

    }

    public interface IMemOperand64<F,T> : IMemOperand<F,W64,T>
        where F : unmanaged, IMemOperand64<F,T>
        where T : unmanaged
    {

    }

    public interface IMemOperand128<F,T> : IMemOperand<F,W128,T>
        where F : unmanaged, IMemOperand128<F,T>
        where T : unmanaged
    {

    }
    public interface IMemOperand256<F,T> : IMemOperand<F,W256,T>
        where F : unmanaged, IMemOperand256<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand512<F,T> : IMemOperand<F,W512,T>
        where F : unmanaged, IMemOperand512<F,T>
        where T : unmanaged
    {

    }

}