// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.Asm.Data;
    
    using static Konst;
    using static Memories;

    public interface IYmmRegOp : IRegOp<W256,Fixed256>
    {
        RegisterClass IRegOp.Class => RegisterClass.YMM;

    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IYmmRegOp<F,N> : IYmmRegOp
        where F : struct, IYmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code => (RegisterCode)value<N>();
    }
}