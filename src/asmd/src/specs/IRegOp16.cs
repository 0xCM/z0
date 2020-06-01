//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface IRegOp16 : IRegOp<W16>
    {
    }

    public interface IRegOp16<S> : IRegOp16, IRegOp<W16,S>
        where S : unmanaged
    {

    }


    public interface IRegOp16<F,N,S> : IRegOp16<S>,IRegOp<F,W16,S>
        where F : unmanaged, IRegOp16<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {

    }

    public interface IRegOp16<F,N> : IRegOp16<F,N,Fixed16>
        where F : unmanaged, IRegOp16<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}