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

    using static Root;
    
    readonly struct AsmBaseAddressProvider : IAsmBaseAddressProvider
    {        
        public IAsmContext Context {get;}
        
        readonly MemoryAddress[] addresses;

        [MethodImpl(Inline)]
        public static AsmBaseAddressProvider Create(IAsmContext context, IEnumerable<MemoryAddress> src)
            => new AsmBaseAddressProvider(context,src);

        [MethodImpl(Inline)]
        public static AsmBaseAddressProvider Create(IAsmContext context, params MemoryAddress[] src)
            => new AsmBaseAddressProvider(context,src);

        [MethodImpl(Inline)]
        AsmBaseAddressProvider(IAsmContext context, IEnumerable<MemoryAddress> src)
        {
            this.Context = context;
            this.addresses = src.OrderBy(x => x.Location).ToArray();
        }

        [MethodImpl(Inline)]
        AsmBaseAddressProvider(IAsmContext context, MemoryAddress[] src)
        {
            this.Context = context;
            this.addresses = src;
        }

        public IEnumerable<MemoryAddress> Terms 
            => addresses;
    }
}