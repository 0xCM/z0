//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMemOperand32<T> : IMemOperand<W32,T> 
        where T : unmanaged
    {

    }

    public interface IMemOperand32<F,T> : IMemOperand32<T>, IMemOperand<F,W32,T>
        where F : unmanaged, IMemOperand32<F,T>
        where T : unmanaged
    {

    }
    
    public interface IMemOperand32 : IMemOperand32<uint>
    {

    }
}