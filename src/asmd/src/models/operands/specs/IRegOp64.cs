//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static Seed;
    using static Memories;

    public interface IRegOp64 : IRegOp<W64,Fixed64>
    {
        RegisterClass IRegOp.Class => RegisterClass.GP;
    }

    public interface IRegOp64<F,N> : IRegOp64
        where F : unmanaged, IRegOp64<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code => (RegisterCode)value<N>();
    }
}