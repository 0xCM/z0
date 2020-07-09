//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures operation invocation information from the client perspective
    /// </summary>
    public readonly struct Invocation
    {
        /// <summary>
        /// The invoking operation
        /// </summary>
        public readonly CallClient Client;
        
        /// <summary>
        /// The base-relative address that captures the offset follows the client call instruction
        /// </summary>
        public readonly ushort CallSite;

        /// <summary>
        /// The argument supplied to the call instruction
        /// </summary>
        public readonly MemoryAddress Target;

        [MethodImpl(Inline)]
        public Invocation(CallClient client, ushort site, MemoryAddress target)        
        {
            Client = client;
            CallSite = site;
            Target = target;
        }

        [MethodImpl(Inline)]
        public Invocation(OpIdentity id, MemoryAddress @base, ushort site, MemoryAddress target)        
        {
            Client = new CallClient(id, @base);
            CallSite = site;
            Target = target;
        }
    }
}