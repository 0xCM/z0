//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static Seed;
    using static Memories;

    public interface IRegOp64 : IRegOp<W64>
    {

    }

    public interface IRegOp64<S> : IRegOp64, IRegOp<W64,S>
        where S : unmanaged
    {

    }

    public interface IRegOp64<F,N> : IRegOp64<Fixed64>
        where F : unmanaged, IRegOp64<F,N>
        where N : unmanaged, ITypeNat
    {
        byte IRegOp.RegisterIndex => (byte)value<N>();
    }
}