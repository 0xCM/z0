//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Pairs a host with instructions decoded from host-defined functions
    /// </summary>         
    public readonly struct HostCodeInstructions 
    {
        public static HostCodeInstructions Empty => Create(ApiHostUri.Empty, Control.array<UriCodeInstructions>());

        /// <summary>
        /// The defining host
        /// </summary>
        public ApiHostUri Host {get;}

        /// <summary>
        /// The decoded instructions for host-defined functions
        /// </summary>
        public UriCodeInstructions[] Instructions {get;}

        /// <summary>
        /// The total instruction count
        /// </summary>
        public int TotalCount => Instructions.Sum(i => i.TotalCount);

        [MethodImpl(Inline)]
        public static HostCodeInstructions Create(UriCodeInstructions[] src)
            => new HostCodeInstructions(ApiHostUri.Empty, src);

        [MethodImpl(Inline)]
        public static HostCodeInstructions Create(ApiHostUri host, UriCodeInstructions[] src)
            => new HostCodeInstructions(host, src);
    
        [MethodImpl(Inline)]        
        public HostCodeInstructions(ApiHostUri host, UriCodeInstructions[] inxs)
        {
            Host = host;
            Instructions = inxs;
        }
    }
}