//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static z;

    public interface IZmmOperand : IRegOperand<W512,FixedCell512>
    {
        RegisterClass IRegOperand.Class
            => RegisterClass.ZMM;
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IZmmOperand<F,N> : IZmmOperand
        where F : struct, IZmmOperand<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOperand.Code
            => (RegisterCode)value<N>();
    }
}