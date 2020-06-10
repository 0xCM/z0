//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Konst;
    using static Memories;

    public interface IRegOp16 : IRegOp<W16,Fixed16>
    {
        RegisterClass IRegOp.Class => RegisterClass.GP;
    }

    public interface IRegOp16<F,N> : IRegOp16
        where F : unmanaged, IRegOp16<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code => (RegisterCode)value<N>();
    }
}