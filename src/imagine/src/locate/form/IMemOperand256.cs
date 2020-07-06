//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemOperand256<T> : IMemOperand<W256,T> 
        where T : unmanaged
    {

    }

    public interface IMemOperand256<F,T> : IMemOperand256<T>, IMemOperand<F,W256,T>
        where F : unmanaged, IMemOperand256<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand256 : IMemOperand256<Fixed256>
    {

    }
}