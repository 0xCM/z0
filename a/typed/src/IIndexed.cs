//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IIndexed<N> : IIndexed
        where N : unmanaged, ITypeNat
    {
        int IIndexed.Position => (int)default(N).NatValue;
    }
}