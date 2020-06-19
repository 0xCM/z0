//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an address-identified target
    /// </summary>
    public interface IAddressable
    {
        MemoryAddress Address {get;}
    }     

    public interface IAddressable<F> : IAddressable, INullity, INullary<F>
        where F : unmanaged, IAddressable<F>
    {

    }

    public interface IAddressable<W,T> : IAddressable
        where W : unmanaged, ITypeWidth
        where T : unmanaged
    {
        
    }       
}