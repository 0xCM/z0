//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface IRegOp64 : IRegOp<W64>
    {

    }

    public interface IRegOp64<S> : IRegOp64, IRegOp<W64,S>
        where S : unmanaged
    {

    }

    public interface IRegOp64<F,N,S> : IRegOp64<S>, IRegOp<F,W64,S>
        where F : unmanaged, IRegOp64<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {

    }

    public interface IRegOp64<F,N> : IRegOp64<F,N,Fixed64>
        where F : unmanaged, IRegOp64<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}