//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;
    using static As;

    public interface IIndexedAddress<T> : IAddress<T>, ISized, INaturalized
        where T : unmanaged
    {
        BitSize ISized.Width 
            => As.bitsize<T>();

        ulong INaturalized.Natural 
            => uint64(Location);
    }

    public interface IIndexedAddress<W,T> : IIndexedAddress<T>, ISized<W>
        where W : unmanaged, IDataWidth
        where T : unmanaged
    {
        
    }

    public interface IIndexedAddress<W,N,T> : IIndexedAddress<T>, INaturalized<N>, ISized<W>
        where W : unmanaged, IDataWidth
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        
    }

    public interface IIndexedAddress<F,W,N,T> : IIndexedAddress<T>, INaturalized<N>, ISized<W>
        where F : unmanaged, IIndexedAddress<F,W,N,T>
        where W : unmanaged, IDataWidth
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        
    }    
}