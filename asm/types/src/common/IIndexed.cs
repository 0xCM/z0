//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IIndexed<N>
        where N : unmanaged, ITypeNat
    {
        int Position => (int)default(N).NatValue;
    }

}