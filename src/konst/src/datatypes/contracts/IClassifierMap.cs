//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IClassifierMap<I,K>
        where I : unmanaged
        where K : unmanaged
    {
        uint Count {get;}

        ref Paired<I,K> Index(uint i);

        ref Paired<K,I> Kind(uint i);
    }

    public interface IClassifierMapHost<H,I,K> : IClassifierMap<I,K>
        where H : struct, IClassifierMapHost<H,I,K>
        where I : unmanaged
        where K : unmanaged
    {

    }
}