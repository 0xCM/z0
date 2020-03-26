//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Characterizes an address-identified target
    /// </summary>
    public interface IAddressable
    {
        MemoryAddress Address {get;}
    }        


}