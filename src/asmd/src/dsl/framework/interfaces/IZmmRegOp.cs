//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    public interface IZmmRegOp : IRegOp<W512,Fixed512>
    {
        RegisterClass IRegOp.Class 
            => RegisterClass.ZMM;        
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IZmmRegOp<F,N> : IZmmRegOp
        where F : struct, IZmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code 
            => (RegisterCode)value<N>();
    }    
}