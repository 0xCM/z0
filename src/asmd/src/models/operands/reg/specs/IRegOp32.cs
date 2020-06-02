//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using static Seed;
    using static Memories;

    public interface IRegOp32 : IRegOp<W32>
    {

    }

    public interface IRegOp32<S> : IRegOp32, IRegOp<W32,S>
        where S : unmanaged
    {

    }

    public interface IRegOp32<F,N> : IRegOp16<Fixed32>
        where F : unmanaged, IRegOp32<F,N>
        where N : unmanaged, ITypeNat
    {
        byte IRegOp.RegisterIndex => (byte)value<N>();
    }
}