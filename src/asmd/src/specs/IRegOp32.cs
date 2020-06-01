//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface IRegOp32 : IRegOp<W32>
    {

    }

    public interface IRegOp32<S> : IRegOp32, IRegOp<W32,S>
        where S : unmanaged
    {

    }

    public interface IRegOp32<F,N,S> : IRegOp32<S>, IRegOp<F,W32,S>
        where F : unmanaged, IRegOp32<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {        

    }

    public interface IRegOp32<F,N> : IRegOp16<F,N,Fixed32>
        where F : unmanaged, IRegOp32<F,N>
        where N : unmanaged, ITypeNat
    {

    }

}