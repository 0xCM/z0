//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static Seed;
    using static Memories;

    public interface IRegOp8 : IRegOp<W8>
    {
             
    }

    public interface IRegOp8<S> : IRegOp8, IRegOp<W8,S>
        where S : unmanaged
    {            
    
    }

    public interface IRegOp8<F,N> : IRegOp8<Fixed8>
        where F : unmanaged, IRegOp8<F,N>
        where N : unmanaged, ITypeNat
    {
        byte IRegOp.RegisterIndex => (byte)value<N>();
    }
}