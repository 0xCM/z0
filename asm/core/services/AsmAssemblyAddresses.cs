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
    
    using static Root;

    readonly struct AsmAssemblyAddresses : IAsmAssemblyAddresses
    {        
        public IAsmContext Context {get;}

        readonly IAsmHostAddresses HostProvider;        

        [MethodImpl(Inline)]
        public static AsmAssemblyAddresses Create(IAsmContext context)
            => new AsmAssemblyAddresses(context);

        [MethodImpl(Inline)]
        AsmAssemblyAddresses(IAsmContext context)
        {
            this.Context = context;
            this.HostProvider = default;
        }

        IEnumerable<OpAddress> HostAddresses(Type host)
            => HostProvider.Addresses(host);

        public IEnumerable<OpAddress> Addresses(Assembly src)
              => src.ApiHosts().Select(h => h.HostingType).SelectMany(HostAddresses);                                
    }
}