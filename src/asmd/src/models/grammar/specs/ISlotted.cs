//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    public interface ISlotted
    {
        int Position {get;}
    }

    public interface ISlotted<N> : ISlotted
        where N : unmanaged, ITypeNat
    {
        int ISlotted.Position => (int)TypeNats.value<N>();
    }

}