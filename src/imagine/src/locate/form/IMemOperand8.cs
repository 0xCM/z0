//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface IMemOperand8<T> : IMemOperand<W8,T> 
        where T : unmanaged
    {

    }

    public interface IMemOperand8<F,T> : IMemOperand8<T>, IMemOperand<F,W8,T>
        where F : unmanaged, IMemOperand8<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand8 : IMemOperand8<byte>
    {

    }
}