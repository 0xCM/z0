//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface IRegOp8 : IRegOp<W8>
    {
             
    }

    public interface IRegOp8<S> : IRegOp8, IRegOp<W8,S>
        where S : unmanaged
    {            
    
    }

    public interface IRegOp8<F,N,S> : IRegOp8<S>, IRegOp<F,W8,S>
        where F : unmanaged, IRegOp8<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
        
    }

    public interface IRegOp8<F,N> : IRegOp8<F,N,Fixed8>
        where F : unmanaged, IRegOp8<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}