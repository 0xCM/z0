//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    
    public interface IAddressProvider<P> : IAsmService
    {
        IEnumerable<MemoryAddress> Addresses(P src);
    }

    /// <summary>
    /// Specifies a service operation that calculates base addresses for host-defined operations
    /// </summary>
    public interface IAddressProvider<P,A> : IAddressProvider<P>
        where A : IAddressable
    {
        /// <summary>
        /// Calculates the operations defined by the host
        /// </summary>
        /// <param name="src">The defining host</param>
        new IEnumerable<A> Addresses(P src);         

        IEnumerable<MemoryAddress> IAddressProvider<P>.Addresses(P src)
            => from a in Addresses(src)  select a.Address;
    }

    public interface IAsmHostAddresses : IAddressProvider<Type, OpAddress>
    {
        
    }

    public interface IAsmAssemblyAddresses : IAddressProvider<Assembly, OpAddress>
    {
        
    }
}