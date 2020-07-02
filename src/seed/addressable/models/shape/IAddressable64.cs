//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes an address-identified target
    /// </summary>
    public interface IAddressable64
    {
        MemoryAddress Address {get;}
    }     

    // public interface IMemoryAddress64 : IAddressable64, IIdentification<MemoryAddress>
    // {

    // }
}