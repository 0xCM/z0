//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IXmmRegOp : IRegOp<W128, Fixed128>    
    {        
        RegisterClass IRegOp.Class 
            => RegisterClass.XMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IXmmRegOp<F,R> : IXmmRegOp, IRegOp<W128,Fixed128>
        where F : struct, IXmmRegOp<F,R>
        where R : unmanaged
    {

    }    
}