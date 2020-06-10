// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static Seed;
    using static Memories;

    public interface IXmmRegOp : IRegOp<W128, Fixed128>    
    {        
        RegisterClass IRegOp.Class => RegisterClass.XMM;
    }

    /// <summary>
    /// Characterizes a 128-bit vectorized register reification of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IXmmRegOp<F,N> : IXmmRegOp
        where F : struct, IXmmRegOp<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code => (RegisterCode)value<N>();
    }
}