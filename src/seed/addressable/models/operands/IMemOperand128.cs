//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemOperand128<T> : IMemOperand<W128,T> 
        where T : unmanaged
    {

    }

    public interface IMemOperand128<F,T> : IMemOperand128<T>, IMemOperand<F,W128,T>
        where F : unmanaged, IMemOperand128<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand128 : IMemOperand128<Fixed128>
    {

    }
}