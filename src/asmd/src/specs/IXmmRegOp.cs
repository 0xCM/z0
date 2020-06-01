// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface IXmmRegOp : IRegOp<W128>
    {        
        
    }

    public interface IXmmRegOp<S> : IXmmRegOp, IRegOp<W128,S>
        where S : unmanaged
    {            
    
    }

    public interface IXmmRegOp<F,N,S> : IXmmRegOp<S>, IRegOp<F,W128,S>
        where F : struct, IXmmRegOp<F,N,S>
        where N : unmanaged, ITypeNat
        where S : unmanaged
    {
           
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IXmmRegOp<F,N> : IXmmRegOp<F,N,Fixed128> 
        where F : struct, IXmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {

    }
}