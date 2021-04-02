//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IZmmReg : IReg<W512,Cell512>
    {
    }

    /// <summary>
    /// Characterizes 128-bit vectorized register reifications of parametric index
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="N">The index type</typeparam>
    public interface IZmmReg<F,N> : IZmmReg
        where F : struct, IZmmReg<F,N>
        where N : unmanaged, ITypeNat
    {
        RegIndex IReg.Index
            => (RegIndex)TypeNats.nat64u<N>();
    }
}