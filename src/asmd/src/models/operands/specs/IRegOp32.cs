//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static Seed;
    using static Memories;

    public interface IRegOp32 : IRegOp<W32,Fixed32>
    {
        RegisterClass IRegOp.Class => RegisterClass.GP;
    }

    public interface IRegOp32<F,N> : IRegOp32
        where F : unmanaged, IRegOp32<F,N>
        where N : unmanaged, ITypeNat
    {
        RegisterCode IRegOp.Code => (RegisterCode)value<N>();
    }
}