// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static Seed;
    using static Memories;

    public interface IYmmRegOp : IRegOp<W256>
    {

    }

    public interface IYmmRegOp<S> : IYmmRegOp, IRegOp<W256,S>
        where S : unmanaged
    {            
    
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IYmmRegOp<F,N> : IYmmRegOp<Fixed256>
        where F : struct, IYmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        byte IRegOp.RegisterIndex => (byte)value<N>();   
    }
}