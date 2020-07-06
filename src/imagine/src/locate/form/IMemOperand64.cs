//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemOperand64<T> : IMemOperand<W64,T> 
        where T : unmanaged
    {

    }

    public interface IMemOperand64<F,T> : IMemOperand64<T>, IMemOperand<F,W64,T>
        where F : unmanaged, IMemOperand64<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand64 : IMemOperand64<ulong>
    {

    }
}