//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemOperand512<T> : IMemOperand<W512,T> 
        where T : unmanaged
    {

    }

    public interface IMemOperand512<F,T> : IMemOperand512<T>, IMemOperand<F,W512,T>
        where F : unmanaged, IMemOperand512<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand512 : IMemOperand512<Fixed512>
    {

    }
}