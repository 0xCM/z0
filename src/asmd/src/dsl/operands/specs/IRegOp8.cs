//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Z0.Asm.Data;
    
    using static Konst;
    using static Memories;

    public interface IRegOp8 : IRegOp<W8,Fixed8>
    {
        RegisterClass IRegOp.Class => RegisterClass.GP;
    }
    
    public interface IRegOp8<F,N> : IRegOp8
        where F : unmanaged, IRegOp8<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code => (RegisterCode)value<N>();
    }
}