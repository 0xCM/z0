//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IAsmMemOperand : IAsmOperand
    {
        AsmOperandKind IAsmOperand.OpKind 
            => AsmOperandKind.M;
    }

    public interface IAsmMemOperand<T> : IAsmMemOperand, IAsmOperand<T>
        where T : unmanaged
    {

    }

    public interface IAsmMemOperand<W,T> : IAsmMemOperand<T>, IAsmOperand<W,T>
        where T : unmanaged
        where W : unmanaged, ITypeWidth
    {
        
    }

    public interface IAsmMemOperand<F,W,T> : IAsmMemOperand<W,T>, IAsmOperand<F,W,T>
        where T : unmanaged
        where F : unmanaged, IAsmMemOperand<F,W,T>
        where W : unmanaged, ITypeWidth
    {

    }

    public interface IAsmMemOperand8<F,T> : IAsmMemOperand<F,W8,T>
        where F : unmanaged, IAsmMemOperand8<F,T>
        where T : unmanaged
    {

    }

    public interface IAsmMemOperand16<F,T> : IAsmMemOperand<F,W16,T>
        where F : unmanaged, IAsmMemOperand16<F,T>
        where T : unmanaged
    {

    }
    
    public interface IAsmMemOperand32<F,T> : IAsmMemOperand<F,W32,T>
        where F : unmanaged, IAsmMemOperand32<F,T>
        where T : unmanaged
    {

    }

    public interface IAsmMemOperand64<F,T> : IAsmMemOperand<F,W64,T>
        where F : unmanaged, IAsmMemOperand64<F,T>
        where T : unmanaged
    {

    }

    public interface IAsmMemOperand128<F,T> : IAsmMemOperand<F,W128,T>
        where F : unmanaged, IAsmMemOperand128<F,T>
        where T : unmanaged
    {

    }
    public interface IAsmMemOperand256<F,T> : IAsmMemOperand<F,W256,T>
        where F : unmanaged, IAsmMemOperand256<F,T>
        where T : unmanaged
    {

    }
    
    public interface IAsmMemOperand512<F,T> : IAsmMemOperand<F,W512,T>
        where F : unmanaged, IAsmMemOperand512<F,T>
        where T : unmanaged
    {

    }

}